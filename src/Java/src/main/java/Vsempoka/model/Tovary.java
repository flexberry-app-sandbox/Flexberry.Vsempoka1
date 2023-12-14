package Vsempoka.model;

import org.eclipse.persistence.annotations.Convert;
import org.eclipse.persistence.annotations.Converter;
import Vsempoka.utils.UUIDConverter;

import javax.persistence.*;
import java.util.UUID;


/**
 * Entity implementation class for Entity: Товары
 */
@Entity(name = "IISVsempokaТовары")
@Table(schema = "public", name = "Товары")
public class Tovary {

    @Id
    @Converter(converterClass = UUIDConverter.class, name = "primarykey")
    @Convert("primarykey")
    @Column(name = "primarykey", length = 16, unique = true, nullable = false)
    private UUID primarykey;

    @Column(name = "НаимТовара")
    private String наимтовара;

    @Column(name = "Производитель")
    private String производитель;

    @Column(name = "ЕдиницыИзмер")
    private String единицыизмер;

    @Column(name = "Цены")
    private Integer цены;

    @Column(name = "Масса")
    private Integer масса;


    public Tovary() {
        super();
    }

    public void setPrimarykey(UUID primarykey) {
        this.primarykey = primarykey;
    }

    public UUID getPrimarykey() {
        return primarykey;
    }

    public String getНаимТовара() {
      return наимтовара;
    }

    public void setНаимТовара(String наимтовара) {
      this.наимтовара = наимтовара;
    }

    public String getПроизводитель() {
      return производитель;
    }

    public void setПроизводитель(String производитель) {
      this.производитель = производитель;
    }

    public String getЕдиницыИзмер() {
      return единицыизмер;
    }

    public void setЕдиницыИзмер(String единицыизмер) {
      this.единицыизмер = единицыизмер;
    }

    public Integer getЦены() {
      return цены;
    }

    public void setЦены(Integer цены) {
      this.цены = цены;
    }

    public Integer getМасса() {
      return масса;
    }

    public void setМасса(Integer масса) {
      this.масса = масса;
    }


}