using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RecipesNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesNet.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var scope = serviceProvider.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();

                if (!context.IngredientType.Any())
                {
                    context.IngredientType.AddRange(
                        new IngredientType
                        {
                            Name = "Egg"
                        },
                        new IngredientType
                        {
                            Name = "Meat"
                        },
                        new IngredientType
                        {
                            Name = "Fish"
                        },
                        new IngredientType
                        {
                            Name = "Grain"
                        },
                        new IngredientType
                        {
                            Name = "Spice"
                        }
                    );
                    context.SaveChanges();
                }

                if (!context.EnergyValue.Any())
                {
                    context.EnergyValue.AddRange(
                         new EnergyValue
                         {
                             Fat = 0,
                             Protein = 2,
                             Carbohydrate = 5,
                             Calorie = 100
                         },
                         new EnergyValue
                         {
                             Fat = 10,
                             Protein = 5,
                             Carbohydrate = 20,
                             Calorie = 400
                         }
                     );
                    context.SaveChanges();
                }

                if (!context.Ingredient.Any())
                {
                    context.Ingredient.AddRange(
                         new Ingredient
                         {
                             Name = "Wheat",
                             Description = "Wheat is a grass widely cultivated for its seed, a cereal grain which is a worldwide staple food.",
                             TypeId = 4,
                             EnergyValueId = 1
                         },
                         new Ingredient
                         {
                             Name = "Fish",
                             Description = "Fish are gill-bearing aquatic craniate animals that lack limbs with digits.",
                             TypeId = 3,
                             EnergyValueId = 2
                         },
                         new Ingredient
                         {
                             Name = "Spice",
                             Description = "A spice is a seed, fruit, root, bark, or other plant substance primarily used for flavoring, coloring or preserving food.",
                             TypeId = 5,
                             EnergyValueId = 1
                         },
                         new Ingredient
                         {
                             Name = "Onion",
                             Description = "The onion also known as the bulb onion or common onion, is a vegetable that is the most widely cultivated species of the genus Allium.",
                             TypeId = 5,
                             EnergyValueId = 1
                         }
                     );
                    context.SaveChanges();
                }

                if (!context.DishType.Any())
                {
                    context.DishType.AddRange(
                         new DishType
                         {
                             Name = "Main",
                             Description = "The main dish is usually the heaviest, heartiest, and most complex or substantial dish in a meal. The main ingredient is usually meat, fish or another protein source. It is most often preceded by an appetizer, soup or salad, and followed by a dessert. For those reasons the main course is sometimes referred to as the 'meat course'."
                         },
                         new DishType
                         {
                             Name = "Salad",
                             Description = "A salad is a dish consisting of a mixture of small pieces of food, usually vegetables or fruit. However, different varieties of salad may contain virtually any type of ready-to-eat food. Salads are typically served at room temperature or chilled, with notable exceptions such as south German potato salad which can be served warm."
                         },
                         new DishType
                         {
                             Name = "Dessert",
                             Description = "Usually consists of sweet foods, such as confections, and possibly a beverage such as dessert wine or liqueur."
                         }
                     );
                    context.SaveChanges();
                }

                if (!context.Cuisine.Any())
                {
                    context.Cuisine.AddRange(
                         new Cuisine
                         {
                             Name = "European",
                             Description = "European cuisine (alternatively, 'Western cuisine') include the cuisines of Europe and other Western countries. European cuisine includes that of Europe and to some extent Russia, as well as non-indigenous cuisines of North America, Australasia, Oceania, and Latin America. The term is used by East Asians to contrast with Asian styles of cooking. This is analogous to Westerners referring collectively to the cuisines of Asian countries as Asian cuisine. When used by Westerners, the term may refer more specifically to cuisine in Europe; in this context, a synonym is Continental cuisine, especially in British English."
                         },
                         new Cuisine
                         {
                             Name = "Asian",
                             Description = "Asian cuisines are many and varied. Ingredients common to many cultures in the east and Southeast regions of the continent include rice, ginger, garlic, sesame seeds, chilies, dried onions, soy, and tofu. Stir frying, steaming, and deep frying are common cooking methods. While rice is common to most Asian cuisines, different varieties are popular in the various regions; Basmati rice is popular in the South Asia, Jasmine is often found across the southeast, while long-grain rice is popular in China and short-grain in Japan and Korea. Curry is also a common dish found in southern and eastern Asia, however, they are not as popular in western Asian cuisines. Those curry dishes with origins in India and other South Asian countries usually have a yogurt base while Southeastern and Eastern curries generally use coconut milk as their foundation."
                         }
                     );
                    context.SaveChanges();
                }

                if (!context.Recipe.Any())
                {
                    
                    context.Recipe.AddRange(
                        new Recipe
                        {
                            Name = "Grilled fish",
                            DishTypeId = 3,
                            CuisineId = 2,
                            CookingTime = DateTime.MinValue.AddMinutes(40),
                            Ingredients = new List<IngredientItem>
                             {
                                 new IngredientItem { IngredientId = 3, Quantity = 400 },
                                 new IngredientItem { IngredientId = 2, Quantity = 10 },
                                 new IngredientItem { IngredientId = 1, Quantity = 50 }
                             },
                            Instructions = new List<InstructionStep>
                             {
                                 new InstructionStep { Entry = "Lorem ipsum dolor sit amet, soleat vivendum no vix, nam ut sonet dicant. Mei duis adversarium cu. Sed ridens senserit no. Vim solet evertitur ea. Cum te scripta iudicabit, ea mei ferri molestiae. Sint purto integre vis an." },
                                 new InstructionStep { Entry = "Usu eius graeco at, ea eam scripta oportere, eros blandit interpretaris quo in. In dicta eloquentiam ius, errem fastidii liberavisse in est, denique suavitate mei at. Ne eos augue noster. Semper delenit no vis, graeci expetendis an vel." },
                                 new InstructionStep { Entry = "Ex mei graece libris dictas. Est exerci aliquip an, malis postea tritani ut est. Unum albucius suscipiantur per ei. Paulo debitis mea at, eos ei homero ponderum comprehensam. Quem etiam aperiri te vel, at zril platonem cum, et movet alienum offendit nam." },
                                 new InstructionStep { Entry = "Qui quaeque fuisset no, eos verear aliquam et, mei primis audiam hendrerit ex. Consul saperet cu cum, at graeci omnesque vis. Duo alienum probatus assentior ea, at his soleat euripidis disputationi. Sea an oblique graecis, ad his bonorum inimicus neglegentur, ad debet inciderint pro. Sonet prompta accusam ne qui, nec solet omittam no. Mea at quod rebum." },
                             }
                        },
                        new Recipe
                        {
                            Name = "Borscht",
                            DishTypeId = 3,
                            CuisineId = 2,
                            CookingTime = DateTime.MinValue.AddMinutes(50),
                            Ingredients = new List<IngredientItem>
                             {
                                 new IngredientItem { IngredientId = 3, Quantity = 400 },
                                 new IngredientItem { IngredientId = 2, Quantity = 10 },
                                 new IngredientItem { IngredientId = 1, Quantity = 50 }
                             },
                            Instructions = new List<InstructionStep>
                             {
                                 new InstructionStep { Entry = "Lorem ipsum dolor sit amet, soleat vivendum no vix, nam ut sonet dicant. Mei duis adversarium cu. Sed ridens senserit no. Vim solet evertitur ea. Cum te scripta iudicabit, ea mei ferri molestiae. Sint purto integre vis an." },
                                 new InstructionStep { Entry = "Facer offendit intellegam his cu, ad senserit convenire sea. Qui tale tacimates atomorum ei, sea ut tantas persecuti mnesarchum, alterum voluptua definitionem eu nec. Vim diam cibo consetetur id, ancillae sententiae no pri. Stet error aeterno qui et, quot integre cum te. Hinc quas elitr cu nec. Decore iuvaret consulatu cu vel. Mea viris invenire no." },
                                 new InstructionStep { Entry = "Movet nonumes et ius. Est aeque populo eligendi ne, prima ullum efficiantur an usu. Sed ea tritani persecuti. Sit at novum efficiantur. Usu semper possim ullamcorper cu. Ea mea solet tantas delenit, stet fabellas apeirian sed an." },
                                 new InstructionStep { Entry = "Ex mei graece libris dictas. Est exerci aliquip an, malis postea tritani ut est. Unum albucius suscipiantur per ei. Paulo debitis mea at, eos ei homero ponderum comprehensam. Quem etiam aperiri te vel, at zril platonem cum, et movet alienum offendit nam." },
                                 new InstructionStep { Entry = "Qui quaeque fuisset no, eos verear aliquam et, mei primis audiam hendrerit ex. Consul saperet cu cum, at graeci omnesque vis. Duo alienum probatus assentior ea, at his soleat euripidis disputationi. Sea an oblique graecis, ad his bonorum inimicus neglegentur, ad debet inciderint pro. Sonet prompta accusam ne qui, nec solet omittam no. Mea at quod rebum." },
                             }
                        },
                        new Recipe
                        {
                            Name = "Sushi",
                            DishTypeId = 2,
                            CuisineId = 1,
                            CookingTime = DateTime.MinValue.AddMinutes(30),
                            Ingredients = new List<IngredientItem>
                             {
                                 new IngredientItem { IngredientId = 3, Quantity = 400 },
                                 new IngredientItem { IngredientId = 2, Quantity = 10 },
                                 new IngredientItem { IngredientId = 1, Quantity = 50 }
                             },
                            Instructions = new List<InstructionStep>
                             {
                                 new InstructionStep { Entry = "Lorem ipsum dolor sit amet, soleat vivendum no vix, nam ut sonet dicant. Mei duis adversarium cu. Sed ridens senserit no. Vim solet evertitur ea. Cum te scripta iudicabit, ea mei ferri molestiae. Sint purto integre vis an." },
                                 new InstructionStep { Entry = "Usu eius graeco at, ea eam scripta oportere, eros blandit interpretaris quo in. In dicta eloquentiam ius, errem fastidii liberavisse in est, denique suavitate mei at. Ne eos augue noster. Semper delenit no vis, graeci expetendis an vel." },
                                 new InstructionStep { Entry = "Ex mei graece libris dictas. Est exerci aliquip an, malis postea tritani ut est. Unum albucius suscipiantur per ei. Paulo debitis mea at, eos ei homero ponderum comprehensam. Quem etiam aperiri te vel, at zril platonem cum, et movet alienum offendit nam." },
                                 new InstructionStep { Entry = "Qui quaeque fuisset no, eos verear aliquam et, mei primis audiam hendrerit ex. Consul saperet cu cum, at graeci omnesque vis. Duo alienum probatus assentior ea, at his soleat euripidis disputationi. Sea an oblique graecis, ad his bonorum inimicus neglegentur, ad debet inciderint pro. Sonet prompta accusam ne qui, nec solet omittam no. Mea at quod rebum." },
                             }
                        },
                        new Recipe
                        {
                            Name = "Ramen",
                            DishTypeId = 3,
                            CuisineId = 1,
                            CookingTime = DateTime.MinValue.AddMinutes(40),
                            Ingredients = new List<IngredientItem>
                             {
                                 new IngredientItem { IngredientId = 3, Quantity = 400 },
                                 new IngredientItem { IngredientId = 2, Quantity = 10 },
                                 new IngredientItem { IngredientId = 1, Quantity = 50 }
                             },
                            Instructions = new List<InstructionStep>
                             {
                                 new InstructionStep { Entry = "Lorem ipsum dolor sit amet, soleat vivendum no vix, nam ut sonet dicant. Mei duis adversarium cu. Sed ridens senserit no. Vim solet evertitur ea. Cum te scripta iudicabit, ea mei ferri molestiae. Sint purto integre vis an." },
                                 new InstructionStep { Entry = "Facer offendit intellegam his cu, ad senserit convenire sea. Qui tale tacimates atomorum ei, sea ut tantas persecuti mnesarchum, alterum voluptua definitionem eu nec. Vim diam cibo consetetur id, ancillae sententiae no pri. Stet error aeterno qui et, quot integre cum te. Hinc quas elitr cu nec. Decore iuvaret consulatu cu vel. Mea viris invenire no." },
                                 new InstructionStep { Entry = "Usu eius graeco at, ea eam scripta oportere, eros blandit interpretaris quo in. In dicta eloquentiam ius, errem fastidii liberavisse in est, denique suavitate mei at. Ne eos augue noster. Semper delenit no vis, graeci expetendis an vel." },
                                 new InstructionStep { Entry = "Ex mei graece libris dictas. Est exerci aliquip an, malis postea tritani ut est. Unum albucius suscipiantur per ei. Paulo debitis mea at, eos ei homero ponderum comprehensam. Quem etiam aperiri te vel, at zril platonem cum, et movet alienum offendit nam." },
                                 new InstructionStep { Entry = "Qui quaeque fuisset no, eos verear aliquam et, mei primis audiam hendrerit ex. Consul saperet cu cum, at graeci omnesque vis. Duo alienum probatus assentior ea, at his soleat euripidis disputationi. Sea an oblique graecis, ad his bonorum inimicus neglegentur, ad debet inciderint pro. Sonet prompta accusam ne qui, nec solet omittam no. Mea at quod rebum." },
                             }
                        },
                        new Recipe
                        {
                            Name = "Crepes",
                            DishTypeId = 1,
                            CuisineId = 2,
                            CookingTime = DateTime.MinValue.AddMinutes(10),
                            Ingredients = new List<IngredientItem>
                             {
                                 new IngredientItem { IngredientId = 3, Quantity = 400 },
                                 new IngredientItem { IngredientId = 2, Quantity = 10 },
                                 new IngredientItem { IngredientId = 1, Quantity = 50 }
                             },
                            Instructions = new List<InstructionStep>
                             {
                                 new InstructionStep { Entry = "Lorem ipsum dolor sit amet, soleat vivendum no vix, nam ut sonet dicant. Mei duis adversarium cu. Sed ridens senserit no. Vim solet evertitur ea. Cum te scripta iudicabit, ea mei ferri molestiae. Sint purto integre vis an." },
                                 new InstructionStep { Entry = "Facer offendit intellegam his cu, ad senserit convenire sea. Qui tale tacimates atomorum ei, sea ut tantas persecuti mnesarchum, alterum voluptua definitionem eu nec. Vim diam cibo consetetur id, ancillae sententiae no pri. Stet error aeterno qui et, quot integre cum te. Hinc quas elitr cu nec. Decore iuvaret consulatu cu vel. Mea viris invenire no." },
                                 new InstructionStep { Entry = "Movet nonumes et ius. Est aeque populo eligendi ne, prima ullum efficiantur an usu. Sed ea tritani persecuti. Sit at novum efficiantur. Usu semper possim ullamcorper cu. Ea mea solet tantas delenit, stet fabellas apeirian sed an." },
                                 new InstructionStep { Entry = "Usu eius graeco at, ea eam scripta oportere, eros blandit interpretaris quo in. In dicta eloquentiam ius, errem fastidii liberavisse in est, denique suavitate mei at. Ne eos augue noster. Semper delenit no vis, graeci expetendis an vel." },
                                 new InstructionStep { Entry = "Ex mei graece libris dictas. Est exerci aliquip an, malis postea tritani ut est. Unum albucius suscipiantur per ei. Paulo debitis mea at, eos ei homero ponderum comprehensam. Quem etiam aperiri te vel, at zril platonem cum, et movet alienum offendit nam." },
                                 new InstructionStep { Entry = "Qui quaeque fuisset no, eos verear aliquam et, mei primis audiam hendrerit ex. Consul saperet cu cum, at graeci omnesque vis. Duo alienum probatus assentior ea, at his soleat euripidis disputationi. Sea an oblique graecis, ad his bonorum inimicus neglegentur, ad debet inciderint pro. Sonet prompta accusam ne qui, nec solet omittam no. Mea at quod rebum." },
                             }
                        },
                        new Recipe
                        {
                            Name = "Plov",
                            DishTypeId = 3,
                            CuisineId = 1,
                            CookingTime = DateTime.MinValue.AddMinutes(50),
                            Ingredients = new List<IngredientItem>
                             {
                                 new IngredientItem { IngredientId = 3, Quantity = 400 },
                                 new IngredientItem { IngredientId = 2, Quantity = 10 },
                                 new IngredientItem { IngredientId = 1, Quantity = 50 }
                             },
                            Instructions = new List<InstructionStep>
                             {
                                 new InstructionStep { Entry = "Lorem ipsum dolor sit amet, soleat vivendum no vix, nam ut sonet dicant. Mei duis adversarium cu. Sed ridens senserit no. Vim solet evertitur ea. Cum te scripta iudicabit, ea mei ferri molestiae. Sint purto integre vis an." },
                                 new InstructionStep { Entry = "Facer offendit intellegam his cu, ad senserit convenire sea. Qui tale tacimates atomorum ei, sea ut tantas persecuti mnesarchum, alterum voluptua definitionem eu nec. Vim diam cibo consetetur id, ancillae sententiae no pri. Stet error aeterno qui et, quot integre cum te. Hinc quas elitr cu nec. Decore iuvaret consulatu cu vel. Mea viris invenire no." },
                                 new InstructionStep { Entry = "Usu eius graeco at, ea eam scripta oportere, eros blandit interpretaris quo in. In dicta eloquentiam ius, errem fastidii liberavisse in est, denique suavitate mei at. Ne eos augue noster. Semper delenit no vis, graeci expetendis an vel." },
                                 new InstructionStep { Entry = "Ex mei graece libris dictas. Est exerci aliquip an, malis postea tritani ut est. Unum albucius suscipiantur per ei. Paulo debitis mea at, eos ei homero ponderum comprehensam. Quem etiam aperiri te vel, at zril platonem cum, et movet alienum offendit nam." },
                                 new InstructionStep { Entry = "Qui quaeque fuisset no, eos verear aliquam et, mei primis audiam hendrerit ex. Consul saperet cu cum, at graeci omnesque vis. Duo alienum probatus assentior ea, at his soleat euripidis disputationi. Sea an oblique graecis, ad his bonorum inimicus neglegentur, ad debet inciderint pro. Sonet prompta accusam ne qui, nec solet omittam no. Mea at quod rebum." },
                             }
                        },
                        new Recipe
                        {
                            Name = "Tiramisu",
                            DishTypeId = 1,
                            CuisineId = 2,
                            CookingTime = DateTime.MinValue.AddMinutes(20),
                            Ingredients = new List<IngredientItem>
                             {
                                 new IngredientItem { IngredientId = 3, Quantity = 400 },
                                 new IngredientItem { IngredientId = 2, Quantity = 10 },
                                 new IngredientItem { IngredientId = 1, Quantity = 50 }
                             },
                            Instructions = new List<InstructionStep>
                             {
                                 new InstructionStep { Entry = "Lorem ipsum dolor sit amet, soleat vivendum no vix, nam ut sonet dicant. Mei duis adversarium cu. Sed ridens senserit no. Vim solet evertitur ea. Cum te scripta iudicabit, ea mei ferri molestiae. Sint purto integre vis an." },
                                 new InstructionStep { Entry = "Facer offendit intellegam his cu, ad senserit convenire sea. Qui tale tacimates atomorum ei, sea ut tantas persecuti mnesarchum, alterum voluptua definitionem eu nec. Vim diam cibo consetetur id, ancillae sententiae no pri. Stet error aeterno qui et, quot integre cum te. Hinc quas elitr cu nec. Decore iuvaret consulatu cu vel. Mea viris invenire no." },
                                 new InstructionStep { Entry = "Ex mei graece libris dictas. Est exerci aliquip an, malis postea tritani ut est. Unum albucius suscipiantur per ei. Paulo debitis mea at, eos ei homero ponderum comprehensam. Quem etiam aperiri te vel, at zril platonem cum, et movet alienum offendit nam." },
                                 new InstructionStep { Entry = "Qui quaeque fuisset no, eos verear aliquam et, mei primis audiam hendrerit ex. Consul saperet cu cum, at graeci omnesque vis. Duo alienum probatus assentior ea, at his soleat euripidis disputationi. Sea an oblique graecis, ad his bonorum inimicus neglegentur, ad debet inciderint pro. Sonet prompta accusam ne qui, nec solet omittam no. Mea at quod rebum." },
                             }
                        },
                        new Recipe
                        {
                            Name = "Burger",
                            DishTypeId = 3,
                            CuisineId = 2,
                            CookingTime = DateTime.MinValue.AddMinutes(15),
                            Ingredients = new List<IngredientItem>
                             {
                                 new IngredientItem { IngredientId = 3, Quantity = 400 },
                                 new IngredientItem { IngredientId = 2, Quantity = 10 },
                                 new IngredientItem { IngredientId = 1, Quantity = 50 }
                             },
                            Instructions = new List<InstructionStep>
                             {
                                 new InstructionStep { Entry = "Lorem ipsum dolor sit amet, soleat vivendum no vix, nam ut sonet dicant. Mei duis adversarium cu. Sed ridens senserit no. Vim solet evertitur ea. Cum te scripta iudicabit, ea mei ferri molestiae. Sint purto integre vis an." },
                                 new InstructionStep { Entry = "Ex mei graece libris dictas. Est exerci aliquip an, malis postea tritani ut est. Unum albucius suscipiantur per ei. Paulo debitis mea at, eos ei homero ponderum comprehensam. Quem etiam aperiri te vel, at zril platonem cum, et movet alienum offendit nam." },
                                 new InstructionStep { Entry = "Qui quaeque fuisset no, eos verear aliquam et, mei primis audiam hendrerit ex. Consul saperet cu cum, at graeci omnesque vis. Duo alienum probatus assentior ea, at his soleat euripidis disputationi. Sea an oblique graecis, ad his bonorum inimicus neglegentur, ad debet inciderint pro. Sonet prompta accusam ne qui, nec solet omittam no. Mea at quod rebum." },
                             }
                        }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
