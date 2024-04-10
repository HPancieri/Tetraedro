using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour {

    public GameObject tetrahedron; // prefab da camrera
    public GameObject[] vetGameObj = new GameObject[24];
    GameObject pai;
     Vector3 m_Center;
    // Use this for initialization
    void Start () {
        for(int i=0; i < 24; i++) {
            if(i == 0) {
                vetGameObj[i] = Instantiate(tetrahedron, new Vector3(0, 0, 0), Quaternion.identity); // tetraedro base
            } else {
                vetGameObj[i]= Instantiate(tetrahedron, new Vector3(vetGameObj[i-1].transform.position.x + 1, 0, 0), vetGameObj[i - 1].transform.rotation);
                //i-1 posicao anterior
            }
        }

        //pegar tetra da posicao 3 e transladar
        vetGameObj[3].transform.position = new Vector3(0.5f, 0.86603f, 0.28868f);
        vetGameObj[4].transform.position = new Vector3(1.5f, 0.86603f, 0.28868f);
        vetGameObj[5].transform.position = new Vector3(1f, 1.73206f, 0.57736f);
        vetGameObj[6].transform.position = new Vector3(1.5f, 0f, 0.86603f);
        vetGameObj[7].transform.position = new Vector3(0.5f, 0f, 0.86603f);
        vetGameObj[8].transform.position = new Vector3(1f, 0f, 1.73206f);
        vetGameObj[9].transform.position = new Vector3(1f, 0.86603f, 1.15471f);

        vetGameObj[10].transform.position = new Vector3(1.5f, 0.86603f, 0.28868f);
        vetGameObj[10].transform.Rotate(37f, 0f, 180f);

        vetGameObj[11].transform.position =new Vector3(2.5f, 0.86603f, 0.28868f);
        vetGameObj[11].transform.Rotate(37f, 0f, 180f);

        vetGameObj[12].transform.position = new Vector3(2f, 1.73206f, 0.57736f);
        vetGameObj[12].transform.Rotate(37f, 0f, 180f);

        // Para o lado amarelo, os eixos serão:
        Vector3 newZaxis = new Vector3(1.5f - 2.25f, 0.86603f - 0.86603f, 0.28868f - 0.72169f);
        Vector3 newXaxis = new Vector3(2f - 2.5f, 0.86603f - 0.86603f, 1.15471f - 0.28868f);

        vetGameObj[13].transform.position = new Vector3(1.5f, 0.86603f, 0.28868f);
        pai = new GameObject();
        pai.transform.position = new Vector3(2.5f, 0.86603f, 0.28868f);
        vetGameObj[13].transform.parent = pai.transform;
        pai.transform.RotateAround(pai.transform.position, newZaxis, 180f);
        pai.transform.RotateAround(pai.transform.position, newXaxis, 37f);
        pai = new GameObject();
        pai.transform.position = new Vector3(3f, 0f, 0f);
        vetGameObj[13].transform.parent = pai.transform;
        pai.transform.position = new Vector3(2.5f, 0f, 0.86603f);

        vetGameObj[14].transform.position = new Vector3(1f, 0.86603f, 1.15471f);
        pai = new GameObject();
        pai.transform.position = new Vector3(2f, 0.86603f, 1.15471f);
        vetGameObj[14].transform.parent = pai.transform;
        pai.transform.RotateAround(pai.transform.position, newZaxis, 180f);
        pai.transform.RotateAround(pai.transform.position, newXaxis, 37f);
        pai = new GameObject();
        pai.transform.position = new Vector3(2.5f, 0f, 0.86603f);
        vetGameObj[14].transform.parent = pai.transform;
        pai.transform.position = new Vector3(2f, 0f, 1.73206f);

        vetGameObj[15].transform.position = new Vector3(1f, 1.73206f, 0.57736f);
        pai = new GameObject();
        pai.transform.position = new Vector3(2f, 1.73206f, 0.57736f);
        vetGameObj[15].transform.parent = pai.transform;
        pai.transform.RotateAround(pai.transform.position, newZaxis, 180f);
        pai.transform.RotateAround(pai.transform.position, newXaxis, 37f);
        pai = new GameObject();
        pai.transform.position = new Vector3(2.5f, 0.86603f, 0.28868f);
        vetGameObj[15].transform.parent = pai.transform;
        pai.transform.position = new Vector3(2f, 0.86603f, 1.15471f);


        // Para o lado vermelho, os eixos serão:
        newZaxis = new Vector3(2f - 1.24827f, 0.86603f - 0.86603f, 1.15471f - 1.58385f);
        newXaxis = new Vector3(1f - 1.5f, 0.86603f - 0.86603f, 1.15471f - 2.02074f);

        vetGameObj[16].transform.position = new Vector3(1f, 0.86603f, 1.15471f);
        pai = new GameObject();
        pai.transform.position = new Vector3(1.5f, 0.86603f, 2.02074f);
        vetGameObj[16].transform.parent = pai.transform;
        pai.transform.RotateAround(pai.transform.position, newZaxis, 180f);
        pai.transform.RotateAround(pai.transform.position, newXaxis, 37f);
        pai = new GameObject();
        pai.transform.position = new Vector3(1.5f, 0f, 2.59809f);
        vetGameObj[16].transform.parent = pai.transform;
        pai.transform.position = new Vector3(1f, 0f, 1.73206f);

        vetGameObj[17].transform.position = new Vector3(0.5f, 0.86603f, 0.28868f);
        pai = new GameObject();
        pai.transform.position = new Vector3(1f, 0.86603f, 1.15471f);
        vetGameObj[17].transform.parent = pai.transform;
        pai.transform.RotateAround(pai.transform.position, newZaxis, 180f);
        pai.transform.RotateAround(pai.transform.position, newXaxis, 37f);
        pai = new GameObject();
        pai.transform.position = new Vector3(1f, 0f, 1.73206f);
        vetGameObj[17].transform.parent = pai.transform;
        pai.transform.position = new Vector3(0.5f, 0f, 0.86603f);

        vetGameObj[18].transform.position = new Vector3(1f, 1.73206f, 0.57736f);
        pai = new GameObject();
        pai.transform.position = new Vector3(1.5f, 1.73206f, 1.44339f);
        vetGameObj[18].transform.parent = pai.transform;
        pai.transform.RotateAround(pai.transform.position, newZaxis, 180f);
        pai.transform.RotateAround(pai.transform.position, newXaxis, 37f);
        pai = new GameObject();
        pai.transform.position = new Vector3(1.5f, 0.86603f, 2.02074f);
        vetGameObj[18].transform.parent = pai.transform;
        pai.transform.position = new Vector3(1f, 0.86603f, 1.15471f);


        // Para a face azul, os eixos serão:
        newZaxis = new Vector3(2f - 2f, 0.86603f - 0f, 1.15471f - 0.86603f);
        newXaxis = new Vector3(1.5f - 2.5f, 0f - 0f, 0.86603f - 0.86603f);

        vetGameObj[19].transform.position = new Vector3(1.5f, 0f, 0.86603f);
        pai = new GameObject();
        pai.transform.position = new Vector3(2.5f, 0f, 0.86603f);
        vetGameObj[19].transform.parent = pai.transform;
        pai.transform.RotateAround(pai.transform.position, newZaxis, 180f);
        pai.transform.RotateAround(pai.transform.position, newXaxis, 37f);
        pai = new GameObject();
        pai.transform.position = new Vector3(3f, 0f, 0f);
        vetGameObj[19].transform.parent = pai.transform;
        pai.transform.position = new Vector3(2f, 0f, 0f);

        vetGameObj[20].transform.position = new Vector3(0.5f, 0f, 0.86603f);
        pai = new GameObject();
        pai.transform.position = new Vector3(1.5f, 0f, 0.86603f);
        vetGameObj[20].transform.parent = pai.transform;
        pai.transform.RotateAround(pai.transform.position, newZaxis, 180f);
        pai.transform.RotateAround(pai.transform.position, newXaxis, 37f);
        pai = new GameObject();
        pai.transform.position = new Vector3(2f, 0f, 0f);
        vetGameObj[20].transform.parent = pai.transform;
        pai.transform.position = new Vector3(1f, 0f, 0f);

        vetGameObj[21].transform.position = new Vector3(1f, 0f, 1.73206f);
        pai = new GameObject();
        pai.transform.position = new Vector3(2f, 0f, 1.73206f);
        vetGameObj[21].transform.parent = pai.transform;
        pai.transform.RotateAround(pai.transform.position, newZaxis, 180f);
        pai.transform.RotateAround(pai.transform.position, newXaxis, 37f);
        pai = new GameObject();
        pai.transform.position = new Vector3(2.5f, 0f, 0.86603f);
        vetGameObj[21].transform.parent = pai.transform;
        pai.transform.position = new Vector3(1.5f, 0f, 0.86603f);

        foreach (GameObject gameObj in vetGameObj) {
			gameObj.transform.parent = null;
		}
    }

    
    // Update is called once per frame
    void Update () {

        #region Planos da esquerda
        // Plano da esquerda da primeira camada inclida esquerda 
        Plane planoEL1P1 = new Plane(
            new Vector3(0.0625f, 0.10206f, 0.03608f),
            new Vector3(0.0625f, 0f, 0.10825f),
            new Vector3(0.125f, 0f, 0f)
        );
        // Plano da direita da primeira camada inclida esquerda 
        Plane planoEL1P2 = new Plane(
            new Vector3(0.48438f, 0f, 0.83896f),
            new Vector3(0.96875f, 0f, 0f),
            new Vector3(0.48438f, 0.27965f, 0.79098f)
        );
        // Plano da esquerda da segunda camada inclida esquerda 
        Plane planoEL2P1 = new Plane(
            new Vector3(0.51563f, 0.84201f, 0.2977f),
            new Vector3(0.51563f, 0f, 0.89309f),
            new Vector3(1.03125f, 0f, 0f)
        );
        // Plano da esquerda da terceira camada inclida esquerda 
        Plane planoEL3P1 = new Plane(
            new Vector3(1.01563f, 1.65851f, 0.58637f),
            new Vector3(1.01563f, 0f, 1.75911f),
            new Vector3(2.03125f, 0f, 0f)
        );
        // Plano fora do tetraedro da terceira camada inclida esquerda 
        Plane planoEL3P2Out = new Plane(
            new Vector3(3.5f, 0f, 0f),
            new Vector3(1.75f, 2.85774f, 1.01036f),
            new Vector3(1.75f, 0f, 3.03109f)
        );
        #endregion

        #region Planos da diretira
        // Plano da esquerda da primeira camada inclida esquerda 
        Plane planoDL1P1 = new Plane(
            new Vector3(2.9375f, 0.10206f, 0.03608f),
            new Vector3(2.9375f, 0f, 0.10825f),
            new Vector3(2.875f, 0f, 0f)
        );
        // Plano da direita da primeira camada inclida esquerda 
        Plane planoDL1P2 = new Plane(
            new Vector3(2.51563f, 0f, 0.83896f),
            new Vector3(2.03125f, 0f, 0f),
            new Vector3(2.51563f, 0.79098f, 0.27965f)
        );
        // Plano da esquerda da segunda camada inclida esquerda 
        Plane planoDL2P1 = new Plane(
            new Vector3(2.48438f, 0.84201f, 0.2977f),
            new Vector3(2.48438f, 0f, 0.89309f),
            new Vector3(1.96875f, 0f, 0f)
        );
        // Plano da esquerda da terceira camada inclida esquerda 
        Plane planoDL3P1 = new Plane(
            new Vector3(1.98438f, 1.65851f, 0.58637f),
            new Vector3(1.98438f, 0f, 1.75911f),
            new Vector3(0.96875f, 0f, 0f)
        );
        // Plano fora do tetraedro da terceira camada inclida esquerda 
        Plane planoDL3P2Out = new Plane(
            new Vector3(-0.5f, 0f, 0f),
            new Vector3(1.25f, 2.85774f, 1.01036f),
            new Vector3(1.25f, 0f, 3.03109f)
        );
        #endregion

        #region Planos de tras
        // Plano de tras da primeira camada inclida tras 
        Plane planoTL1P1 = new Plane(
            new Vector3(1.53125f, 0f, 2.54395f),
            new Vector3(1.5f, 0.05103f, 2.56199f),
            new Vector3(1.46875f, 0f, 2.54395f)
        );
        // Plano da frente da primeira camada inclida tras 
        Plane planoTL1P2 = new Plane(
            new Vector3(1.01563f, 0f, 1.75911f),
            new Vector3(1.98438f, 0f, 1.75911f),
            new Vector3(1.5f, 0.79098f, 2.03877f)
        );
        // Plano de tras da segunda camada inclida tras 
        Plane planoTL2P1 = new Plane(
            new Vector3(2.01563f, 0f, 1.70499f),
            new Vector3(1.5f, 0.84201f, 2.00268f),
            new Vector3(0.98438f, 0f, 1.70499f)
        );
        // Plano de tras da terceira camada inclida tras 
        Plane planoTL3P1 = new Plane(
            new Vector3(1.5f, 1.65851f, 1.42533f),
            new Vector3(0.48438f, 0f, 0.83896f),
            new Vector3(2.51563f, 0f, 0.83896f)
        );
        // Plano fora do tetraedro da terceira camada inclida tras 
        Plane planoTL3P2Out = new Plane(
            new Vector3(3.25f, 0f, -0.43302f),
            new Vector3(1.5f, 2.85774f, 0.57735f),
            new Vector3(-0.25f, 0f, -0.43302f)
        );
        #endregion

        #region Rotacao base, meio e topo
        // Rotaciona o topo
		if (Input.GetKeyUp(KeyCode.F1)) {
			Plane rotPlane = new Plane(
					new Vector3(1.25f, 2.16507f, 0.72169f), 
					new Vector3(1.75f, 2.16507f, 0.72169f),
					new Vector3(1.5f, 2.16507f, 1.15471f)
			);
			Vector3 rotAxis = new Vector3(1.5f - 1.5f, 2.59809f - 0f, 0.86603f - 0.86603f);
			Vector3 pivotPosition = new Vector3(1.5f, 0f, 0.86603f);
			HandleIntersection(rotPlane, rotAxis, pivotPosition);
		}
        // Rotaciona o meio
		if (Input.GetKeyUp(KeyCode.F2)) {
			Plane rotPlane = new Plane(
                    new Vector3(0.875f, 1.51555f, 0.50519f),
                    new Vector3(1.5f, 1.51555f, 1.58772f),
                    new Vector3(2.125f, 1.51555f, 0.50519f)
			);
			Vector3 rotAxis = new Vector3(1.5f - 1.5f, 2.59809f - 0f, 0.86603f - 0.86603f);
			Vector3 pivotPosition = new Vector3(1.5f, 0f, 0.86603f);
			HandleIntersection(rotPlane, rotAxis, pivotPosition);
		}
        // Rotaciona a base
        if (Input.GetKeyUp(KeyCode.F3)) {
            Plane rotPlane = new Plane(
                    new Vector3(0.375f, 0.6495225f, 0.21651f),
                    new Vector3(1.5f, 0.6495225f, 2.1650729f),
                    new Vector3(2.625f, 0.6495225f, 0.21651f)
            );
            Vector3 rotAxis = new Vector3(1.5f - 1.5f, 2.59809f - 0f, 0.86603f - 0.86603f);
			Vector3 pivotPosition = new Vector3(1.5f, 0f, 0.86603f);
			HandleIntersection(rotPlane, rotAxis, pivotPosition);
        }
        #endregion

        #region Rotacao das camadas inclidas da ESQUERDA
        // Rotaciona primeira camada inclinada da esquerda
        if (Input.GetKeyUp(KeyCode.F4)) {
            Vector3 rotAxis = new Vector3(0f - 2f, 0f - 0.86603f, 0f - 1.15471f);
            Vector3 pivotPosition = new Vector3(2f, 0.86603f, 1.15471f);
            HandleIntersectionInclinedPlanesLeft(planoEL1P1, planoEL1P2, rotAxis, pivotPosition);
        }
        // Rotaciona primeira camada inclinada da esquerda
        if (Input.GetKeyUp(KeyCode.F5)) {
            Vector3 rotAxis = new Vector3(0f - 2f, 0f - 0.86603f, 0f - 1.15471f);
            Vector3 pivotPosition = new Vector3(2f, 0.86603f, 1.15471f);
            HandleIntersectionInclinedPlanesLeft(planoEL2P1, planoEL3P1, rotAxis, pivotPosition);
        }
        // Rotaciona primeira camada inclinada da esquerda
        if (Input.GetKeyUp(KeyCode.F6)) {
            Vector3 rotAxis = new Vector3(0f - 2f, 0f - 0.86603f, 0f - 1.15471f);
            Vector3 pivotPosition = new Vector3(2f, 0.86603f, 1.15471f);
            HandleIntersectionInclinedPlanesLeft(planoEL3P1, planoEL3P2Out, rotAxis, pivotPosition);
        }
        #endregion

        #region Rotacao das camadas inclidas da DIREITA
        // Rotaciona primeira camada inclinada da edireita
        if (Input.GetKeyUp(KeyCode.F7)) {
            Vector3 rotAxis = new Vector3(3f - 1f, 0f - 0.86603f, 0f - 1.15471f);
            Vector3 pivotPosition = new Vector3(1f, 0.86603f, 1.15471f);
            HandleIntersectionInclinedPlanesRight(planoDL1P1, planoDL1P2, rotAxis, pivotPosition);
        }
        // Rotaciona primeira camada inclinada da direita
        if (Input.GetKeyUp(KeyCode.F8)) {
            Vector3 rotAxis = new Vector3(3f - 1f, 0f - 0.86603f, 0f - 1.15471f);
            Vector3 pivotPosition = new Vector3(1f, 0.86603f, 1.15471f);
            HandleIntersectionInclinedPlanesRight(planoDL2P1, planoDL3P1, rotAxis, pivotPosition);
        }
        // Rotaciona primeira camada inclinada da direita
        if (Input.GetKeyUp(KeyCode.F9)) {
            Vector3 rotAxis = new Vector3(3f - 1f, 0f - 0.86603f, 0f - 1.15471f);
            Vector3 pivotPosition = new Vector3(1f, 0.86603f, 1.15471f);
            HandleIntersectionInclinedPlanesRight(planoDL3P1, planoDL3P2Out, rotAxis, pivotPosition);
        }
        #endregion

        #region Rotacao das camadas inclidas de TRAS
        // Rotaciona primeira camada inclinada da edireita
        if (Input.GetKeyUp(KeyCode.F10)) {
            Vector3 rotAxis = new Vector3(1.5f - 1.5f, 0f - 0.8165f, 2.59808f - 0.28868f);
            Vector3 pivotPosition = new Vector3(1.5f, 0.8165f, 0.28868f);
            HandleIntersectionInclinedPlanesBack(planoTL1P1, planoTL1P2, rotAxis, pivotPosition);
        }
        // Rotaciona primeira camada inclinada da direita
        if (Input.GetKeyUp(KeyCode.F11)) {
            Vector3 rotAxis = new Vector3(1.5f - 1.5f, 0f - 0.8165f, 2.59808f - 0.28868f);
            Vector3 pivotPosition = new Vector3(1.5f, 0.8165f, 0.28868f);
            HandleIntersectionInclinedPlanesBack(planoTL2P1, planoTL3P1, rotAxis, pivotPosition);
        }
        // Rotaciona primeira camada inclinada da direita
        if (Input.GetKeyUp(KeyCode.F12)) {
            Vector3 rotAxis = new Vector3(1.5f - 1.5f, 0f - 0.8165f, 2.59808f - 0.28868f);
            Vector3 pivotPosition = new Vector3(1.5f, 0.8165f, 0.28868f);
            HandleIntersectionInclinedPlanesBack(planoTL3P1, planoTL3P2Out, rotAxis, pivotPosition);
        }
        #endregion

        #region Rotacao dos eixos
        // Rotaciona eixo Y sentido horario
        if(Input.GetKeyDown(KeyCode.Alpha1)){
            Vector3 rotAxis = new Vector3(1.5f - 1.5f, 2.59809f - 0f, 0.86603f - 0.86603f);
			Vector3 pivotPosition = new Vector3(1.5f, 0f, 0.86603f);
            RotacionaEixos(vetGameObj, rotAxis, pivotPosition, 120f);
        }

        // Rotaciona eixo Z sentido horario
        if(Input.GetKeyUp(KeyCode.Alpha2)){
            Vector3 rotAxis = new Vector3(1.5f - 1.5f, 0f - 0.86603f, 2.59808f - 0.28868f);
			Vector3 pivotPosition = new Vector3(1.5f, 0.86603f, 0.28868f);
            RotacionaEixos(vetGameObj, rotAxis, pivotPosition, -120f);
        }

        // Rotaciona eixo X frente para tras
        if(Input.GetKeyUp(KeyCode.Alpha3)){
            Vector3 rotAxis = new Vector3(2f - 0f, 0.8165f - 0f, 1.1547f - 0f);
			Vector3 pivotPosition = new Vector3(2f, 0.8165f, 1.1547f);
            RotacionaEixos(vetGameObj, rotAxis, pivotPosition, 120f);
        }
        #endregion
    }

    #region Verifica interseccao dos planos da base, meio e topo
	void HandleIntersection(Plane plane, Vector3 axis, Vector3 pivotPosition) {
		List<GameObject> rotObjects = new List<GameObject>();

		foreach (GameObject obj in vetGameObj) {
			Bounds objBounds = obj.GetComponent<Renderer>().bounds;

			if (CheckIntersection(objBounds, plane)) {
				rotObjects.Add(obj);
			}
		}

		pai = new GameObject();
		pai.transform.position = pivotPosition;
		foreach (GameObject obj in rotObjects) {
			obj.transform.parent = pai.transform;
		}
		pai.transform.RotateAround(pai.transform.position, axis, 120f);
	}

    bool CheckIntersection(Bounds obj, Plane plane) {
		Ray ray = new Ray(obj.center, plane.normal);
		float distance;

		if (plane.Raycast(ray, out distance)) {
			Vector3 point = ray.GetPoint(distance);
			return obj.Contains(point);
		}

		return false;
	}
    #endregion

    #region Verifica interseccao dos planos da ESQUERDA
    void HandleIntersectionInclinedPlanesLeft(Plane planeDown, Plane planeUp, Vector3 axis, Vector3 pivotPosition) {
		List<GameObject> rotObjects = new List<GameObject>();

		foreach (GameObject obj in vetGameObj) {
			Bounds objBounds = obj.GetComponent<Renderer>().bounds;

			if (CheckIntersectionInclinedPlanesLeft(objBounds, planeDown, planeUp)) {
				rotObjects.Add(obj);
			}
		}

		pai = new GameObject();
		pai.transform.position = pivotPosition;
		foreach (GameObject obj in rotObjects) {
			obj.transform.parent = pai.transform;
		}
		pai.transform.RotateAround(pai.transform.position, axis, 120f);
	}

    bool CheckIntersectionInclinedPlanesLeft(Bounds obj, Plane planeDown, Plane planeUp) {
        Vector3 directionUp = new Vector3(5.94028f, 2.42511f, 3.42962f);
        Ray rayUp = new Ray(obj.center, directionUp);
		float distance;

        bool verificaUp = false;
        bool verificaDown = false;

        if (planeUp.Raycast(rayUp, out distance)) {
            verificaUp = true;
		}

        if (planeDown.Raycast(rayUp, out distance)) {
            verificaDown = true;
		}

        if(verificaUp && !verificaDown){
            return true;
        }

		return false;
	}
    #endregion

    #region Verifica interseccao dos planos da DIREITA
    void HandleIntersectionInclinedPlanesRight(Plane planeDown, Plane planeUp, Vector3 axis, Vector3 pivotPosition) {
		List<GameObject> rotObjects = new List<GameObject>();

		foreach (GameObject obj in vetGameObj) {
			Bounds objBounds = obj.GetComponent<Renderer>().bounds;

			if (CheckIntersectionInclinedPlanesRight(objBounds, planeDown, planeUp)) {
				rotObjects.Add(obj);
			}
		}

		pai = new GameObject();
		pai.transform.position = pivotPosition;
		foreach (GameObject obj in rotObjects) {
			obj.transform.parent = pai.transform;
		}
		pai.transform.RotateAround(pai.transform.position, axis, 120f);
	}

    bool CheckIntersectionInclinedPlanesRight(Bounds obj, Plane planeDown, Plane planeUp) {
        Vector3 directionUp = new Vector3(-2.94028f, 2.42511f, 3.42962f);
        Ray rayUp = new Ray(obj.center, directionUp);
		float distance;

        bool verificaUp = false;
        bool verificaDown = false;

        if (planeUp.Raycast(rayUp, out distance)) {
            verificaUp = true;
		}

        if (planeDown.Raycast(rayUp, out distance)) {
            verificaDown = true;
		}

        if(verificaUp && !verificaDown){
            return true;
        }

		return false;
	}
    #endregion

    #region Verifica interseccao dos planos de TRAS
    void HandleIntersectionInclinedPlanesBack(Plane planeDown, Plane planeUp, Vector3 axis, Vector3 pivotPosition) {
		List<GameObject> rotObjects = new List<GameObject>();

		foreach (GameObject obj in vetGameObj) {
			Bounds objBounds = obj.GetComponent<Renderer>().bounds;

			if (CheckIntersectionInclinedPlanesBack(objBounds, planeDown, planeUp)) {
				rotObjects.Add(obj);
			}
		}

		pai = new GameObject();
		pai.transform.position = pivotPosition;
		foreach (GameObject obj in rotObjects) {
			obj.transform.parent = pai.transform;
		}
		pai.transform.RotateAround(pai.transform.position, axis, 120f);
	}

    bool CheckIntersectionInclinedPlanesBack(Bounds obj, Plane planeDown, Plane planeUp) {
        Vector3 directionUp = new Vector3(1.5f, 2.4299f, -4.27472f);
        Ray rayUp = new Ray(obj.center, directionUp);
		float distance;

        bool verificaUp = false;
        bool verificaDown = false;

        if (planeUp.Raycast(rayUp, out distance)) {
            verificaUp = true;
		}

        if (planeDown.Raycast(rayUp, out distance)) {
            verificaDown = true;
		}

        if(verificaUp && !verificaDown){
            return true;
        }

		return false;
	}
    #endregion

    #region Rotaciona eixos
    void RotacionaEixos(GameObject[] objects, Vector3 axis, Vector3 pivotPosition, float angulo) {
        pai = new GameObject();
        pai.transform.position = pivotPosition;

        foreach (GameObject obj in objects) {
			obj.transform.parent = pai.transform;
		}

        pai.transform.RotateAround(pai.transform.position, axis, angulo);

        foreach (GameObject obj in objects) {
			obj.transform.parent = null;
		}
    }
    #endregion

}
