(function () {
    'use strict';

    angular.module('core').factory('logger', ['$log', logger]);

    function logger($log) {
        var service = {
            getLogFn: getLogFn,
            log: log,
            logError: logError,
            logSuccess: logSuccess,
            logWarning: logWarning
        };

        return service;

        function getLogFn(moduleId, fnName) {
            fnName = fnName || 'log';
            switch (fnName.toLowerCase()) {
                case 'success':
                    fnName = 'logSuccess'; break;
                case 'error':
                    fnName = 'logError'; break;
                case 'warning':
                    fnName = 'logWarning'; break;
            }

            var logFn = service[fnName] || service.log;
            return function (msg, data, showNotify) {
                logFn(msg, data, moduleId, (showNotify === undefined) ? true : showNotify);
            };
        }

        function log(message, data, source, showNotify) {
            logIt(message, data, source, showNotify, 'info');
        }

        function logWarning(message, data, source, showNotify) {
            logIt(message, data, source, showNotify, 'warning');
        }

        function logSuccess(message, data, source, showNotify) {
            logIt(message, data, source, showNotify, 'success');
        }

        function logError(message, data, source, showNotify) {
            logIt(message, data, source, showNotify, 'error');
        }

        function logIt(message, data, source, showNotify, notifyType) {
            var write = (notifyType === 'error') ? $log.error : $log.log;
            source = source ? '[' + source + '] ' : '';
            write(source, message, data);
            if (showNotify) {
                if (notifyType === 'error') {
                    toastr.error(message);
                } else if (notifyType === 'warning') {
                    toastr.warning(message);
                } else if (notifyType === 'success') {
                    toastr.success(message);
                } else {
                    toastr.info(message);
                }
            }
        }
    }
})();