var JourneyPlannerCtrl = function($scope, JPService) {

    var routes = JPService.getRoutes().then(onSucess, onError);


    var onSucess = function(result) {
        $scope.model = {
            helloAngular: result.data
        };
    };

    var onError = function(error) {
        $scope.model = {
            helloAngular: 'error'
        };
    };

    $scope.model = {
        helloAngular: routes
    };

}