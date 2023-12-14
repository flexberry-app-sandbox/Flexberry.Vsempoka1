import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-vsempoka-докум-постав-l');
  this.route('i-i-s-vsempoka-докум-постав-e',
  { path: 'i-i-s-vsempoka-докум-постав-e/:id' });
  this.route('i-i-s-vsempoka-докум-постав-e.new',
  { path: 'i-i-s-vsempoka-докум-постав-e/new' });
  this.route('i-i-s-vsempoka-клиенты-l');
  this.route('i-i-s-vsempoka-клиенты-e',
  { path: 'i-i-s-vsempoka-клиенты-e/:id' });
  this.route('i-i-s-vsempoka-клиенты-e.new',
  { path: 'i-i-s-vsempoka-клиенты-e/new' });
  this.route('i-i-s-vsempoka-организация-l');
  this.route('i-i-s-vsempoka-организация-e',
  { path: 'i-i-s-vsempoka-организация-e/:id' });
  this.route('i-i-s-vsempoka-организация-e.new',
  { path: 'i-i-s-vsempoka-организация-e/new' });
  this.route('i-i-s-vsempoka-пункт-погрузки-l');
  this.route('i-i-s-vsempoka-пункт-погрузки-e',
  { path: 'i-i-s-vsempoka-пункт-погрузки-e/:id' });
  this.route('i-i-s-vsempoka-пункт-погрузки-e.new',
  { path: 'i-i-s-vsempoka-пункт-погрузки-e/new' });
  this.route('i-i-s-vsempoka-список-барж-l');
  this.route('i-i-s-vsempoka-список-барж-e',
  { path: 'i-i-s-vsempoka-список-барж-e/:id' });
  this.route('i-i-s-vsempoka-список-барж-e.new',
  { path: 'i-i-s-vsempoka-список-барж-e/new' });
  this.route('i-i-s-vsempoka-список-контей-l');
  this.route('i-i-s-vsempoka-список-контей-e',
  { path: 'i-i-s-vsempoka-список-контей-e/:id' });
  this.route('i-i-s-vsempoka-список-контей-e.new',
  { path: 'i-i-s-vsempoka-список-контей-e/new' });
  this.route('i-i-s-vsempoka-товары-l');
  this.route('i-i-s-vsempoka-товары-e',
  { path: 'i-i-s-vsempoka-товары-e/:id' });
  this.route('i-i-s-vsempoka-товары-e.new',
  { path: 'i-i-s-vsempoka-товары-e/new' });
  this.route('i-i-s-vsempoka-формир-док-распр-l');
  this.route('i-i-s-vsempoka-формир-док-распр-e',
  { path: 'i-i-s-vsempoka-формир-док-распр-e/:id' });
  this.route('i-i-s-vsempoka-формир-док-распр-e.new',
  { path: 'i-i-s-vsempoka-формир-док-распр-e/new' });
  this.route('i-i-s-vsempoka-формир-рез-пос-l');
  this.route('i-i-s-vsempoka-формир-рез-пос-e',
  { path: 'i-i-s-vsempoka-формир-рез-пос-e/:id' });
  this.route('i-i-s-vsempoka-формир-рез-пос-e.new',
  { path: 'i-i-s-vsempoka-формир-рез-пос-e/new' });
});

export default Router;
