

//(function(){

var JPApp = angular.module('JP');

var JourneyPlannerCtrl = function($scope, JPService) {


	 var onSucess = function(result) {
        $scope.model = {
            JourneyPlanner : result
        };
    };

    var onError = function(error) {
        $scope.model = {
            JourneyPlanner: "We were unable to retrieve valid routes corresponding to these stations, please try again!"
        };
    };

    var routes = JPService.getRoutes().then(onSucess, onError);

}

JPApp.controller('JourneyPlannerCtrl', JourneyPlannerCtrl);

//})();

