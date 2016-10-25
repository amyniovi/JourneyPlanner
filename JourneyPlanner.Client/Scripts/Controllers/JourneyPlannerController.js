

//(function(){

var JPApp = angular.module('JP');

var JourneyPlannerCtrl = function($scope, JPService) {


	 var onSucess = function(result) {
        $scope.model = {
            helloAngular: result
        };
    };

    var onError = function(error) {
        $scope.model = {
            helloAngular: 'error'
        };
    };

    var routes = JPService.getRoutes().then(onSucess, onError);


   


}

JPApp.controller('JourneyPlannerCtrl', JourneyPlannerCtrl);

//})();

