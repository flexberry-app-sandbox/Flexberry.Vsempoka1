import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import ЕдИзмерEnum from '../enums/i-i-s-vsempoka-ед-измер';

export default FlexberryEnum.extend({
  enum: ЕдИзмерEnum,
  sourceType: 'IIS.Vsempoka.ЕдИзмер'
});
