import Mixin from '@ember/object/mixin';
import $ from 'jquery';

export let Serializer = Mixin.create({
  getAttrs: function () {
    let parentAttrs = this._super();
    let attrs = {
      докумПостав: { serialize: 'odata-id', deserialize: 'records' },
      пунктПогрузки: { serialize: 'odata-id', deserialize: 'records' },
      списокБарж: { serialize: 'odata-id', deserialize: 'records' },
      списокКонтей: { serialize: 'odata-id', deserialize: 'records' }
    };

    return $.extend(true, {}, parentAttrs, attrs);
  },
  init: function () {
    this.set('attrs', this.getAttrs());
    this._super(...arguments);
  }
});
