

//(function(){

var JPApp = angular.module('JP');

var JourneyPlannerCtrl = function($scope, JPService) {


	 var onSucess = function(result) {
        $scope.route = result.data;
        $scope.responseStatus = result.status
          };

    var onError = function(error) {
        $scope.error = "We were unable to retrieve valid routes corresponding to these stations, please try again!";
    };

    $scope.getRoute = function(start, destination){

     var routes = JPService.getRoutes(start, destination).then(onSucess, onError);

    };
   

}

JPApp.controller('JourneyPlannerCtrl', JourneyPlannerCtrl);

//})();

