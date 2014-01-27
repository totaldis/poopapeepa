(function () {
    'use strict';

    var serviceId = 'datacontext';

    angular.module('app').factory(serviceId,
        ['core', 'config', 'entityManagerFactory', datacontext]);

    function datacontext(core, config, emFactory) {


        var service = {

        };

        return service;
    }
})();