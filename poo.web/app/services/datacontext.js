(function () {
    'use strict';

    var serviceId = 'datacontext';

    angular.module('app').factory(serviceId,
        ['core', 'config', 'entityManagerFactory', datacontext]);

    function datacontext(core, config, emFactory) {
        var eQuery = breeze.EntityQuery;
        var manager = emFactory.newManager();

        var getLogFn = core.logger.getLogFn;
        var logError = getLogFn(serviceId, 'error');
        var logWarn = getLogFn(serviceId, 'warn');
        var logSuccess = getLogFn(serviceId, 'success');
        var $q = core.$q;

        var primePromise;
        var lookups;

        var service = {
            primeApp: primeApp,
            lookups: lookups
        };

        return service;

        function primeApp() {
            if (primePromise) return primePromise;
            primePromise = $q.all([setLookups()])
                .then(success);
            return primePromise;

            function success(data) {
                logSuccess('Primed the data');
            }
        }

        function setLookups() {
            service.lookups = {
                priority: getLookups().Importance
            };
        }

        function getLookups() {
            return eQuery.from('Lookups')
                .using(manager).execute()
                .then(success, fail);

            function success(data) {
                logSuccess("Retrieved Lookups", data, true);
                return data.results[0];
            }
        }


        function fail(error) {
            var msg = config.errorPrefix + error.message;
            logError(msg, error);
            throw error;
        }
    }
})();