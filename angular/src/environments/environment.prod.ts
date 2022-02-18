import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'TodoApp2',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44366',
    redirectUri: baseUrl,
    clientId: 'TodoApp2_App',
    responseType: 'code',
    scope: 'offline_access TodoApp2',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44366',
      rootNamespace: 'TodoApp2',
    },
  },
} as Environment;
