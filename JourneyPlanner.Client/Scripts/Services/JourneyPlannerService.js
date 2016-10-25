//(function() {

    var JPService = function($http) {

        var getRoutes = function(start, finish) {

            return $http.get('http://api.openweathermap.org/data/2.5/weather?q=London,uk&appid=16184a974b8bde968a9e68fe0085a3e2') //+ start + '/' + finish)//http://127.0.0.1:8080/api/routes/Holborn/Blackfriars
                .then(function(result) {
                   
                    return {data: result.data,
                    		status: result.status};
                });
        };

        return {
            getRoutes: getRoutes
        };

    };

    var module = angular.module('JP');
    module.factory('JPService', JPService);

//})();