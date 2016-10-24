
var JPService = function($http){

var getRoutes = function(start, finish){

return $http.get('http://127.0.0.1:8080/api/routes/Holborn/Blackfriars')//+ start + '/' + finish)//
.then(function(result){
//return 'service is invoked!';
return result.data;
}

);

};

return {

getRoutes : getRoutes

};


};


var module = angular.module('JP');
module.factory('JPService', JPService);