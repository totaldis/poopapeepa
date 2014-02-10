(function () {
    'use strict';

    var app = angular.module('app', [
        // Angular
        'ngAnimate',
        'ngRoute',
        'ngSanitize',

        // Breeze
        'breeze.angular.q',

        // Custom
        'core'
    ]);

    app.run(['$route', '$rootScope', '$q', 'use$q', 'datacontext',
        function ($route, $rootScope, $q, use$q, datacontext) {
            use$q($q);
            datacontext.primeApp();
        }]);
})();