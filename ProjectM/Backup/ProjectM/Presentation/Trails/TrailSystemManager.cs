// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.Trails.TrailSystemManager
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation.Trails
{
  public class TrailSystemManager : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TRAIL_STEPS;
    private static readonly System.IntPtr NativeFieldInfoPtr__Instance_k__BackingField;
    private static readonly System.IntPtr NativeFieldInfoPtr__MeshPool;
    private static readonly System.IntPtr NativeFieldInfoPtr__IdCounter;
    private static readonly System.IntPtr NativeFieldInfoPtr__FreeSystems;
    private static readonly System.IntPtr NativeFieldInfoPtr__ActiveTrailSystems;
    private static readonly System.IntPtr NativeFieldInfoPtr__ParticleMeshParent;
    private static readonly System.IntPtr NativeFieldInfoPtr_DEFAULT_MAX_PARTICLES;
    private static readonly System.IntPtr NativeFieldInfoPtr__ToRemove;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Instance_Public_Static_get_TrailSystemManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_TrailSystemManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveParticleSystemsCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FreeParticleSystemsCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_FreeParticleMeshesCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ActiveParticleMeshes_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ParticleMeshFails_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Initialize_Public_Static_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LateUpdate_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_RequestTrailSystem_Public_TrailSystemID_EmitterData_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidId_Private_Boolean_TrailSystemID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetParticleSystem_Public_StunParticleSystem_TrailSystemID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetEmitterData_Public_Void_TrailSystemID_EmitterData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReturnParticleSystem_Public_Void_TrailSystemID_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ParticleCount_Public_Int32_TrailSystemID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTrailSystems_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateParticleSystem_Private_Boolean_Single_byref_AllocatedTrailSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTrailMeshes_Private_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateTrailMesh_Private_Void_Single_byref_AllocatedTrailSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateVerticesNeeded_Private_Int32_Int32_MeshType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetVertexStep_Private_Int32_Int32_MeshType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FreeTrailMesh_Private_Void_TrailMesh_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetFreeTrailMesh_Private_TrailMesh_Int32_MeshType_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateNewTrailMesh_Private_GameObject_MeshKey_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public static unsafe TrailSystemManager Instance
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114392, XrefRangeEnd = 1114396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_TrailSystemManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TrailSystemManager) null : new TrailSystemManager(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114396, XrefRangeEnd = 1114401, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_TrailSystemManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int ActiveParticleSystemsCount
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114401, XrefRangeEnd = 1114405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_get_ActiveParticleSystemsCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int FreeParticleSystemsCount
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_get_FreeParticleSystemsCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int FreeParticleMeshesCount
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_get_FreeParticleMeshesCount_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int ActiveParticleMeshes
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_get_ActiveParticleMeshes_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int ParticleMeshFails
    {
      [CallerCount(1474), CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_get_ParticleMeshFails_Public_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1114428, RefRangeEnd = 1114429, XrefRangeStart = 1114405, XrefRangeEnd = 1114428, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void Initialize()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_Initialize_Public_Static_Void_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114429, XrefRangeEnd = 1114465, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Awake()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114465, XrefRangeEnd = 1114472, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void LateUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114472, XrefRangeEnd = 1114515, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void OnApplicationFocus(bool focus)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &focus;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1114536, RefRangeEnd = 1114538, XrefRangeStart = 1114515, XrefRangeEnd = 1114536, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TrailSystemID RequestTrailSystem(EmitterData emitterData, int maxParticleCount = 2000)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) emitterData));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &maxParticleCount;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_RequestTrailSystem_Public_TrailSystemID_EmitterData_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(TrailSystemID*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(25)]
    [CachedScanResults(RefRangeStart = 29168, RefRangeEnd = 29193, XrefRangeStart = 29168, XrefRangeEnd = 29193, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool ValidId(TrailSystemID id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_ValidId_Private_Boolean_TrailSystemID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(5)]
    [CachedScanResults(RefRangeStart = 1114541, RefRangeEnd = 1114546, XrefRangeStart = 1114538, XrefRangeEnd = 1114541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe StunParticleSystem GetParticleSystem(TrailSystemID id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_GetParticleSystem_Public_StunParticleSystem_TrailSystemID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (StunParticleSystem) null : new StunParticleSystem(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114546, XrefRangeEnd = 1114550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetEmitterData(TrailSystemID id, EmitterData data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) data));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_SetEmitterData_Public_Void_TrailSystemID_EmitterData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1114554, RefRangeEnd = 1114557, XrefRangeStart = 1114550, XrefRangeEnd = 1114554, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReturnParticleSystem(TrailSystemID id, bool clearParticles = false)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &id;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &clearParticles;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_ReturnParticleSystem_Public_Void_TrailSystemID_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1474)]
    [CachedScanResults(RefRangeStart = 31223, RefRangeEnd = 32697, XrefRangeStart = 31223, XrefRangeEnd = 32697, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int ParticleCount(TrailSystemID id)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &id;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_ParticleCount_Public_Int32_TrailSystemID_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1114583, RefRangeEnd = 1114584, XrefRangeStart = 1114557, XrefRangeEnd = 1114583, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTrailSystems(float time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &time;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_UpdateTrailSystems_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114584, XrefRangeEnd = 1114585, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool UpdateParticleSystem(
      float time,
      ref TrailSystemManager.AllocatedTrailSystem instance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &time;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) instance);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_UpdateParticleSystem_Private_Boolean_Single_byref_AllocatedTrailSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114585, XrefRangeEnd = 1114589, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTrailMeshes(float time)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &time;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_UpdateTrailMeshes_Private_Void_Single_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1114596, RefRangeEnd = 1114598, XrefRangeStart = 1114589, XrefRangeEnd = 1114596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateTrailMesh(
      float time,
      ref TrailSystemManager.AllocatedTrailSystem instance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &time;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) instance);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_UpdateTrailMesh_Private_Void_Single_byref_AllocatedTrailSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe int CalculateVerticesNeeded(int particleCount, MeshType meshType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &particleCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &meshType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_CalculateVerticesNeeded_Private_Int32_Int32_MeshType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1114603, RefRangeEnd = 1114604, XrefRangeStart = 1114598, XrefRangeEnd = 1114603, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetVertexStep(int particles, MeshType meshType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &particles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &meshType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_GetVertexStep_Private_Int32_Int32_MeshType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1114611, RefRangeEnd = 1114613, XrefRangeStart = 1114604, XrefRangeEnd = 1114611, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void FreeTrailMesh(TrailMesh mesh)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) mesh);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_FreeTrailMesh_Private_Void_TrailMesh_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114613, XrefRangeEnd = 1114626, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TrailMesh GetFreeTrailMesh(int particles, MeshType meshType)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &particles;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &meshType;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_GetFreeTrailMesh_Private_TrailMesh_Int32_MeshType_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (TrailMesh) null : new TrailMesh(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114626, XrefRangeEnd = 1114653, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameObject CreateNewTrailMesh(TrailSystemManager.MeshKey meshInfo)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &meshInfo;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr_CreateNewTrailMesh_Private_GameObject_MeshKey_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114653, XrefRangeEnd = 1114668, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TrailSystemManager()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TrailSystemManager()
    {
      Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation.Trails", nameof (TrailSystemManager));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr);
      TrailSystemManager.NativeFieldInfoPtr_TRAIL_STEPS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, nameof (TRAIL_STEPS));
      TrailSystemManager.NativeFieldInfoPtr__Instance_k__BackingField = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, "<Instance>k__BackingField");
      TrailSystemManager.NativeFieldInfoPtr__MeshPool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, nameof (_MeshPool));
      TrailSystemManager.NativeFieldInfoPtr__IdCounter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, nameof (_IdCounter));
      TrailSystemManager.NativeFieldInfoPtr__FreeSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, nameof (_FreeSystems));
      TrailSystemManager.NativeFieldInfoPtr__ActiveTrailSystems = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, nameof (_ActiveTrailSystems));
      TrailSystemManager.NativeFieldInfoPtr__ParticleMeshParent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, nameof (_ParticleMeshParent));
      TrailSystemManager.NativeFieldInfoPtr_DEFAULT_MAX_PARTICLES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, nameof (DEFAULT_MAX_PARTICLES));
      TrailSystemManager.NativeFieldInfoPtr__ToRemove = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, nameof (_ToRemove));
      TrailSystemManager.NativeMethodInfoPtr_get_Instance_Public_Static_get_TrailSystemManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688203);
      TrailSystemManager.NativeMethodInfoPtr_set_Instance_Private_Static_set_Void_TrailSystemManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688204);
      TrailSystemManager.NativeMethodInfoPtr_get_ActiveParticleSystemsCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688205);
      TrailSystemManager.NativeMethodInfoPtr_get_FreeParticleSystemsCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688206);
      TrailSystemManager.NativeMethodInfoPtr_get_FreeParticleMeshesCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688207);
      TrailSystemManager.NativeMethodInfoPtr_get_ActiveParticleMeshes_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688208);
      TrailSystemManager.NativeMethodInfoPtr_get_ParticleMeshFails_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688209);
      TrailSystemManager.NativeMethodInfoPtr_Initialize_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688210);
      TrailSystemManager.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688211);
      TrailSystemManager.NativeMethodInfoPtr_LateUpdate_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688212);
      TrailSystemManager.NativeMethodInfoPtr_OnApplicationFocus_Private_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688213);
      TrailSystemManager.NativeMethodInfoPtr_RequestTrailSystem_Public_TrailSystemID_EmitterData_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688214);
      TrailSystemManager.NativeMethodInfoPtr_ValidId_Private_Boolean_TrailSystemID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688215);
      TrailSystemManager.NativeMethodInfoPtr_GetParticleSystem_Public_StunParticleSystem_TrailSystemID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688216);
      TrailSystemManager.NativeMethodInfoPtr_SetEmitterData_Public_Void_TrailSystemID_EmitterData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688217);
      TrailSystemManager.NativeMethodInfoPtr_ReturnParticleSystem_Public_Void_TrailSystemID_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688218);
      TrailSystemManager.NativeMethodInfoPtr_ParticleCount_Public_Int32_TrailSystemID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688219);
      TrailSystemManager.NativeMethodInfoPtr_UpdateTrailSystems_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688220);
      TrailSystemManager.NativeMethodInfoPtr_UpdateParticleSystem_Private_Boolean_Single_byref_AllocatedTrailSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688221);
      TrailSystemManager.NativeMethodInfoPtr_UpdateTrailMeshes_Private_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688222);
      TrailSystemManager.NativeMethodInfoPtr_UpdateTrailMesh_Private_Void_Single_byref_AllocatedTrailSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688223);
      TrailSystemManager.NativeMethodInfoPtr_CalculateVerticesNeeded_Private_Int32_Int32_MeshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688224);
      TrailSystemManager.NativeMethodInfoPtr_GetVertexStep_Private_Int32_Int32_MeshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688225);
      TrailSystemManager.NativeMethodInfoPtr_FreeTrailMesh_Private_Void_TrailMesh_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688226);
      TrailSystemManager.NativeMethodInfoPtr_GetFreeTrailMesh_Private_TrailMesh_Int32_MeshType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688227);
      TrailSystemManager.NativeMethodInfoPtr_CreateNewTrailMesh_Private_GameObject_MeshKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688228);
      TrailSystemManager.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, 100688229);
    }

    public TrailSystemManager(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe Il2CppStructArray<int> TRAIL_STEPS
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TrailSystemManager.NativeFieldInfoPtr_TRAIL_STEPS, (void*) &num);
        System.IntPtr nativeObject = num;
        return nativeObject == System.IntPtr.Zero ? (Il2CppStructArray<int>) null : new Il2CppStructArray<int>(nativeObject);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TrailSystemManager.NativeFieldInfoPtr_TRAIL_STEPS, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe TrailSystemManager _Instance_k__BackingField
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(TrailSystemManager.NativeFieldInfoPtr__Instance_k__BackingField, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (TrailSystemManager) null : new TrailSystemManager(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TrailSystemManager.NativeFieldInfoPtr__Instance_k__BackingField, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObjectPool<TrailSystemManager.MeshKey> _MeshPool
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__MeshPool));
        return pointer == System.IntPtr.Zero ? (GameObjectPool<TrailSystemManager.MeshKey>) null : new GameObjectPool<TrailSystemManager.MeshKey>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__MeshPool), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int _IdCounter
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__IdCounter));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__IdCounter)) = value;
      }
    }

    public unsafe List<StunParticleSystem> _FreeSystems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__FreeSystems));
        return pointer == System.IntPtr.Zero ? (List<StunParticleSystem>) null : new List<StunParticleSystem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__FreeSystems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe FastIterationDictionary<TrailSystemID, TrailSystemManager.AllocatedTrailSystem> _ActiveTrailSystems
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__ActiveTrailSystems));
        return pointer == System.IntPtr.Zero ? (FastIterationDictionary<TrailSystemID, TrailSystemManager.AllocatedTrailSystem>) null : new FastIterationDictionary<TrailSystemID, TrailSystemManager.AllocatedTrailSystem>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__ActiveTrailSystems), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Transform _ParticleMeshParent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__ParticleMeshParent));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__ParticleMeshParent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int DEFAULT_MAX_PARTICLES
    {
      get
      {
        int defaultMaxParticles;
        IL2CPP.il2cpp_field_static_get_value(TrailSystemManager.NativeFieldInfoPtr_DEFAULT_MAX_PARTICLES, (void*) &defaultMaxParticles);
        return defaultMaxParticles;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TrailSystemManager.NativeFieldInfoPtr_DEFAULT_MAX_PARTICLES, (void*) &value);
      }
    }

    public unsafe Stack<TrailSystemID> _ToRemove
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__ToRemove));
        return pointer == System.IntPtr.Zero ? (Stack<TrailSystemID>) null : new Stack<TrailSystemID>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.NativeFieldInfoPtr__ToRemove), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct MeshKey
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MeshType;
      private static readonly System.IntPtr NativeFieldInfoPtr_VertexCount;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_MeshType_Int32_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshKey_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public MeshType MeshType;
      [FieldOffset(4)]
      public int VertexCount;

      [CallerCount(57)]
      [CachedScanResults(RefRangeStart = 56553, RefRangeEnd = 56610, XrefRangeStart = 56553, XrefRangeEnd = 56610, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe MeshKey(MeshType meshType, int vertexCount)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &meshType;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &vertexCount;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.MeshKey.NativeMethodInfoPtr__ctor_Public_Void_MeshType_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1114389, XrefRangeEnd = 1114392, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.MeshKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 261548, RefRangeEnd = 261550, XrefRangeStart = 261548, XrefRangeEnd = 261550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(TrailSystemManager.MeshKey other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.MeshKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshKey_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TrailSystemManager.MeshKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static MeshKey()
      {
        Il2CppClassPointerStore<TrailSystemManager.MeshKey>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, nameof (MeshKey));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailSystemManager.MeshKey>.NativeClassPtr);
        TrailSystemManager.MeshKey.NativeFieldInfoPtr_MeshType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager.MeshKey>.NativeClassPtr, nameof (MeshType));
        TrailSystemManager.MeshKey.NativeFieldInfoPtr_VertexCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager.MeshKey>.NativeClassPtr, nameof (VertexCount));
        TrailSystemManager.MeshKey.NativeMethodInfoPtr__ctor_Public_Void_MeshType_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager.MeshKey>.NativeClassPtr, 100688231);
        TrailSystemManager.MeshKey.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager.MeshKey>.NativeClassPtr, 100688232);
        TrailSystemManager.MeshKey.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MeshKey_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager.MeshKey>.NativeClassPtr, 100688233);
        TrailSystemManager.MeshKey.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TrailSystemManager.MeshKey>.NativeClassPtr, 100688234);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrailSystemManager.MeshKey>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    public sealed class AllocatedTrailSystem : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ID;
      private static readonly System.IntPtr NativeFieldInfoPtr_ParticleSystem;
      private static readonly System.IntPtr NativeFieldInfoPtr_TrailMesh;
      private static readonly System.IntPtr NativeFieldInfoPtr_EmitterData;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimeStarted;
      private static readonly System.IntPtr NativeFieldInfoPtr_WaitingForFinish;

      static AllocatedTrailSystem()
      {
        Il2CppClassPointerStore<TrailSystemManager.AllocatedTrailSystem>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TrailSystemManager>.NativeClassPtr, nameof (AllocatedTrailSystem));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TrailSystemManager.AllocatedTrailSystem>.NativeClassPtr);
        TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_ID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager.AllocatedTrailSystem>.NativeClassPtr, nameof (ID));
        TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_ParticleSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager.AllocatedTrailSystem>.NativeClassPtr, nameof (ParticleSystem));
        TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_TrailMesh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager.AllocatedTrailSystem>.NativeClassPtr, nameof (TrailMesh));
        TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_EmitterData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager.AllocatedTrailSystem>.NativeClassPtr, nameof (EmitterData));
        TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_TimeStarted = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager.AllocatedTrailSystem>.NativeClassPtr, nameof (TimeStarted));
        TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_WaitingForFinish = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TrailSystemManager.AllocatedTrailSystem>.NativeClassPtr, nameof (WaitingForFinish));
      }

      public AllocatedTrailSystem(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public AllocatedTrailSystem()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TrailSystemManager.AllocatedTrailSystem>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TrailSystemManager.AllocatedTrailSystem>.NativeClassPtr, data));
      }

      public unsafe TrailSystemID ID
      {
        get
        {
          return *(TrailSystemID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_ID));
        }
        [param: In] set
        {
          *(TrailSystemID*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_ID)) = value;
        }
      }

      public unsafe StunParticleSystem ParticleSystem
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_ParticleSystem));
          return pointer == System.IntPtr.Zero ? (StunParticleSystem) null : new StunParticleSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_ParticleSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TrailMesh TrailMesh
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_TrailMesh));
          return pointer == System.IntPtr.Zero ? (TrailMesh) null : new TrailMesh(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_TrailMesh), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public EmitterData EmitterData
      {
        get
        {
          System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_EmitterData);
          return new EmitterData(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, data));
        }
        [param: In] set
        {
          __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_EmitterData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<EmitterData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        }
      }

      public unsafe float TimeStarted
      {
        get
        {
          return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_TimeStarted));
        }
        [param: In] set
        {
          *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_TimeStarted)) = value;
        }
      }

      public unsafe bool WaitingForFinish
      {
        get
        {
          return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_WaitingForFinish));
        }
        [param: In] set
        {
          *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TrailSystemManager.AllocatedTrailSystem.NativeFieldInfoPtr_WaitingForFinish)) = value;
        }
      }
    }
  }
}
