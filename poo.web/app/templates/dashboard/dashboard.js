(function () {
    'use strict';
    var controllerId = 'dashboard';
    angular.module('app').controller(controllerId, ['core', 'datacontext', dashboard]);

    function dashboard(core, datacontext) {
        var getLogFn = core.logger.getLogFn;
        var log = getLogFn(controllerId);

        var vm = this;
        vm.title = 'Dashboard';

        activate();

        function activate() {
            var promises = [];
            core.activateController(promises, controllerId)
                .then(function () {
                    log('Activated ' + vm.title + ' View');

                });
        }

        function getLists() {

        }
    }
})();