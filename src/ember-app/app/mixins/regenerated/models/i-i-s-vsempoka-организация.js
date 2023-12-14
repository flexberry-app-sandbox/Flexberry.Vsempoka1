import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  наимОрганиз: DS.attr('string')
});

export let ValidationRules = {
  наимОрганиз: {
    descriptionKey: 'models.i-i-s-vsempoka-организация.validations.наимОрганиз.__caption__',
    validators: [
      validator('ds-error'),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('ОрганизацияE', 'i-i-s-vsempoka-организация', {
    наимОрганиз: attr('Наименование организации', { index: 0 })
  });

  modelClass.defineProjection('ОрганизацияL', 'i-i-s-vsempoka-организация', {
    наимОрганиз: attr('Наименование организации', { index: 0 })
  });
};
