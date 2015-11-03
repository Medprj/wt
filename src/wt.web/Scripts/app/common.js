function AppViewModel() {
    var self = this;

    self.city = ko.observable("");
    self.cities = getCitiesFromCookies();
    self.services = ko.observableArray([]);
    self.weatherInfo = ko.observableArray([]);

    self.isLoad = ko.observable(false);

    self.remove = function() {
        self.cities.remove(this);

        saveCitiesToCookies(self.cities);
    };

    self.add = function() {
        if (self.city().trim().length > 0) {
            self.cities.push({ name: self.city() });
            self.city("");
        }

        saveCitiesToCookies(self.cities);
    };

    self.update = function() {
        self.isLoad(true);

        var cities = [];
        for (var i = 0; i < self.cities().length; i++) {
            cities.push(self.cities()[i].name);
        }

        var services = [];
        for (var j = 0; j < self.services().length; j++) {
            services.push(self.services()[j]);
        }
        var params = { cities, services };

        $.ajax({
            url: "home/GetWeatherInfo",
            type: "POST",
            dataType: "JSON",
            data: params,
            success: function(result) {
                ko.mapping.fromJS(result, {}, self.weatherInfo);
            },
            error: function(result) {
                console.log(result);
            },
            complete: function() {
                self.isLoad(false);
            }
        });
    };
}

var saveCitiesToCookies = function(cities) {
    var values = [];
    for (var i = 0; i < cities().length; i++) {
        values.push(cities()[i].name);
    }

    setCookiesAsArr("cities", values);
};

var getCitiesFromCookies = function() {
    var cities = ko.observableArray();
    var values = getCookieAsArr("cities");
    for (var i = 0; i < values.length; i++) {
        cities.push({ name: values[i] });
    }
    return cities;
};

ko.applyBindings(new AppViewModel());