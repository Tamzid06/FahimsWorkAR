
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;
//using UnityEngine.Experimental.UIElements;

public class PanelOpener : MonoBehaviour
{
    public GameObject Panel;
    public Transform TextTargetName;
    public Transform TextDescription;
    //public Transform PanelDescription;

    // Start is called before the first frame update
    void Start()
    {
        Panel.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        StateManager sm = TrackerManager.Instance.GetStateManager();
        IEnumerable<TrackableBehaviour> tbs = sm.GetActiveTrackableBehaviours();

        TextDescription.gameObject.SetActive(false);
       // PanelDescription.gameObject.SetActive(false);



        foreach (TrackableBehaviour tb in tbs)
        {
            string name = tb.TrackableName;
            ImageTarget it = tb.Trackable as ImageTarget;
            Vector2 size = it.GetSize();

            Debug.Log("Active image target:" + name + "  -size: " + size.x + ", " + size.y);


            TextTargetName.GetComponent<Text>().text = name;
            TextDescription.gameObject.SetActive(true);
         //   PanelDescription.gameObject.SetActive(true);



            if (name == "skeletal")
            {
                TextDescription.GetComponent<Text>().text = "You may think of bone as a hard, dense material, but only one type of bone is like this. This dense, hard bone is called cortical bone. Cortical bones are primarily the structure bones.The second type, trabecular bone, is soft and spongy.It’s often found inside large bones and in your pelvis, ribs, and skull.Though it’s less dense than cortical bone, it’s still quite hard and protective.Bones are filled with a spongy tissue.Babies are born with 300 bones . Bones are designed to take a beating . One bone is not connected to any other bones .Biggest joint in body is knee . Bones are strong but teeth are stronger.Functions of the skull include protection of the brain, fixing the distance between the eyes to allow stereoscopic vision, and fixing the position of the ears to enable sound localisation of the direction and distance of sounds. In some animals such as horned ungulates, the skull also has a defensive function by providing the mount (on the frontal bone) for the horns.The English word skull is probably derived from Old Norse skulle, while the Latin word cranium comes from the Greek root κρανίον(kranion).The skull is made up of a number of fused flat bones, and contains many foramina, fossae, processes, and several cavities or sinuses. In zoology there are openings in the skull called fenestrae.";
            }

            if (name == "RibCage")
            {

                TextDescription.GetComponent<Text>().text = "The human skeleton has 12 pairs of ribs.Working from the top of the torso down,ribs 1 to 7 are considered true ribs,as they connect directly from the spine to the sternum,Martinez says.Ribs 8 to 10 are called false ribs,because they don't connect directly,but have cartilage that attaches them to the sternum.Ribs 11 and 12 are called floating ribs,because they only connect to the spine in back.These,he says that they are much shorter.Neanderthals had wider,thicker rib cages than we modern slim-waisted humans, which would have made them terrible models for skinny jeans.A 2016 study in American Journal of Physical Anthropology found that the Ice-Age diet is likely responsible for the larger ribcage and wider pelvis in Neanderthals.The human rib cage is a component of the human respiratory system. It encloses the thoracic cavity, which contains the lungs. An inhalation is accomplished when the muscular diaphragm, at the floor of the thoracic cavity, contracts and flattens, while the contraction of intercostal muscles lift the rib cage up and out.Expansion of the thoracic cavity is driven in three planes; the vertical, the anteroposterior and the transverse. The vertical plane is extended by the help of the diaphragm contracting and the abdominal muscles relaxing to accommodate the downward pressure that is supplied to the abdominal viscera by the diaphragm contracting";
            }

            if (name == "head")
            {
                TextDescription.GetComponent<Text>().text = "The bones that enclose and protect your brain (like a braincase!) form the neurocranium.Need a list of those bones?Here it is:The bones of the neurocranium are the ethmoid,sphenoid,frontal,and occipital bones (one each),and then there are the parietals and temporals (two each).If you take the ethmoid and the sphenoid out of that list you have the bones of the calvaria (the skullcap).The calvaria is a subdivision of the neurocranium. When you talk about the calvaria,you are talking just about the bones on the superior part of the cranium.Foramina are apertures,sometimes called canals,scattered throughout the bones of the skull.These openings commonly function as passageways for nerves and vessels.At the base of the skull,in the occipital bone,is the largest foramen of the skull,the Foramen magnum.Vertebral arteries and the spinal cord pass through this opening.People who have greater than average intelligence are sometimes depicted in cartoons as having bigger heads as a way of notionally indicating that they have a larger brain. Additionally, in science fiction, an extraterrestrial having a big head is often symbolic of high intelligence. Despite this depiction, advances in neurobiology have shown that the functional diversity of the brain means that a difference in overall brain size is only slightly to moderately correlated to differences in overall intelligence between two humans";
            }
            if (name == "heart")
            {
                TextDescription.GetComponent<Text>().text = "The average heart is the size of an adult fist.Your heart will beat about 115,000 times each day.The beating sound your heart makes is caused by the opening and closing of its valves.Each day,your heart pumps about 2,000 gallons of blood.If you were to stretch out your blood vessel system,it would extend over 60,000 miles.The human heart weighs less than one pound,but a man’s heart is typically two ounces heavier than a woman’s.A woman’s heart beats slightly faster than a man’s.There is such a thing as a broken heart.Symptoms are similar to a heart attack but the cause is usually stress and not heart disease.Laughing is good for your heart.It reduces stress and gives a boost to your immune system";
            }
            if (name == "ear")
            {
                TextDescription.GetComponent<Text>().text = "The stapes,also known as the stirrup,is one of the auditory ossicles,consisting of a head,neck,two crura,and base.It looks sort of like a wishbone,or,well,a stirrup!Sound waves strike the eardrum and the vibrations travel into the middle ear.When these vibrations reach the stapes,it pushes the membrane of the oval window,building pressure waves in the cochlea,and this begins a process that generates nerve impulses.The stapedius muscle attaches to the stapes.It stabilizes the bone and dampens large vibrations to protect the oval window from loud noises.The semicircular canals of the vestibule of the inner ear are responsible for balance.They provide sensory input for equilibrium by detecting acceleration or deceleration. Each canal ends in an ampulla;these ampullae contain fluid that moves when the head does.The movement of the fluid causes hair cells to bend, which generates nerve impulses.";
            }


        }
    }






public void TaskOnClick()
    {
        if (Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Debug.Log("*********************************************= " + isActive);
            Panel.SetActive(!isActive);
        }
    }
}
