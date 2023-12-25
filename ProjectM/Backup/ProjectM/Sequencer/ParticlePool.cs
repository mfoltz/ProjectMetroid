// Decompiled with JetBrains decompiler
// Type: ProjectM.Sequencer.ParticlePool
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Sequencer
{
  public class ParticlePool : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_OutsideVision;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseParticlePooling;
    private static readonly System.IntPtr NativeFieldInfoPtr_Parent;
    private static readonly System.IntPtr NativeFieldInfoPtr__PrefabToInstanceQueue;
    private static readonly System.IntPtr NativeFieldInfoPtr__InstanceToPrefab;
    private static readonly System.IntPtr NativeFieldInfoPtr__InstanceIdToGameObject;
    private static readonly System.IntPtr NativeFieldInfoPtr__HideOutsideVisionBlock;
    private static readonly System.IntPtr NativeFieldInfoPtr__Renderers;
    private static readonly System.IntPtr NativeFieldInfoPtr__TrailRenderers;
    private static readonly System.IntPtr NativeFieldInfoPtr_PKillerProp;
    private static readonly System.IntPtr NativeFieldInfoPtr_SeqLifetimeProp;
    private static readonly System.IntPtr NativeFieldInfoPtr_SeqGLifetimeProp;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Transform_Int32_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasInstanceReady_Public_Boolean_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetInstance_Public_GameObject_GameObject_Boolean_Single_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetPrefabInstanceIDFromInstance_Public_Int32_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ReturnInstance_Public_Void_GameObject_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_WarmupPrefab_Public_Void_GameObject_byref_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_InstantiatePrefab_Private_GameObject_GameObject_Single_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ValidateParticleSettings_Private_Static_Void_ParticleSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Clear_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103353, XrefRangeEnd = 1103386, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ParticlePool(
      Transform parent,
      int pKillerProp,
      int seqLifetimeProp,
      int seqGLifetimeProp)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) parent);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &pKillerProp;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &seqLifetimeProp;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &seqGLifetimeProp;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticlePool.NativeMethodInfoPtr__ctor_Public_Void_Transform_Int32_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1103391, RefRangeEnd = 1103392, XrefRangeStart = 1103386, XrefRangeEnd = 1103391, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool HasInstanceReady(GameObject prefab)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticlePool.NativeMethodInfoPtr_HasInstanceReady_Public_Boolean_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1103477, RefRangeEnd = 1103478, XrefRangeStart = 1103392, XrefRangeEnd = 1103477, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameObject GetInstance(
      GameObject prefab,
      bool hideOutsideVision,
      float playbackSpeed,
      out bool instantiatedPrefab)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &hideOutsideVision;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &playbackSpeed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref instantiatedPrefab;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticlePool.NativeMethodInfoPtr_GetInstance_Public_GameObject_GameObject_Boolean_Single_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103478, XrefRangeEnd = 1103482, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int GetPrefabInstanceIDFromInstance(GameObject instance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) instance);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticlePool.NativeMethodInfoPtr_GetPrefabInstanceIDFromInstance_Public_Int32_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1103504, RefRangeEnd = 1103506, XrefRangeStart = 1103482, XrefRangeEnd = 1103504, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void ReturnInstance(GameObject instance)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) instance);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticlePool.NativeMethodInfoPtr_ReturnInstance_Public_Void_GameObject_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1103506, XrefRangeEnd = 1103511, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void WarmupPrefab(GameObject prefab, out bool prefabAlreadyWarmedUp)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) ref prefabAlreadyWarmedUp;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticlePool.NativeMethodInfoPtr_WarmupPrefab_Public_Void_GameObject_byref_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1103571, RefRangeEnd = 1103574, XrefRangeStart = 1103511, XrefRangeEnd = 1103571, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe GameObject InstantiatePrefab(
      GameObject prefab,
      float playbackSpeed,
      bool hideOutsideVision)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) prefab);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &playbackSpeed;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &hideOutsideVision;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ParticlePool.NativeMethodInfoPtr_InstantiatePrefab_Private_GameObject_GameObject_Single_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1103596, RefRangeEnd = 1103597, XrefRangeStart = 1103574, XrefRangeEnd = 1103596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ValidateParticleSettings(ParticleSettings particleSettings)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) particleSettings);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticlePool.NativeMethodInfoPtr_ValidateParticleSettings_Private_Static_Void_ParticleSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1103637, RefRangeEnd = 1103638, XrefRangeStart = 1103597, XrefRangeEnd = 1103637, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Clear()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ParticlePool.NativeMethodInfoPtr_Clear_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ParticlePool()
    {
      Il2CppClassPointerStore<ParticlePool>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Sequencer", nameof (ParticlePool));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr);
      ParticlePool.NativeFieldInfoPtr_OutsideVision = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (OutsideVision));
      ParticlePool.NativeFieldInfoPtr_UseParticlePooling = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (UseParticlePooling));
      ParticlePool.NativeFieldInfoPtr_Parent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (Parent));
      ParticlePool.NativeFieldInfoPtr__PrefabToInstanceQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (_PrefabToInstanceQueue));
      ParticlePool.NativeFieldInfoPtr__InstanceToPrefab = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (_InstanceToPrefab));
      ParticlePool.NativeFieldInfoPtr__InstanceIdToGameObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (_InstanceIdToGameObject));
      ParticlePool.NativeFieldInfoPtr__HideOutsideVisionBlock = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (_HideOutsideVisionBlock));
      ParticlePool.NativeFieldInfoPtr__Renderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (_Renderers));
      ParticlePool.NativeFieldInfoPtr__TrailRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (_TrailRenderers));
      ParticlePool.NativeFieldInfoPtr_PKillerProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (PKillerProp));
      ParticlePool.NativeFieldInfoPtr_SeqLifetimeProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (SeqLifetimeProp));
      ParticlePool.NativeFieldInfoPtr_SeqGLifetimeProp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, nameof (SeqGLifetimeProp));
      ParticlePool.NativeMethodInfoPtr__ctor_Public_Void_Transform_Int32_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, 100687519);
      ParticlePool.NativeMethodInfoPtr_HasInstanceReady_Public_Boolean_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, 100687520);
      ParticlePool.NativeMethodInfoPtr_GetInstance_Public_GameObject_GameObject_Boolean_Single_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, 100687521);
      ParticlePool.NativeMethodInfoPtr_GetPrefabInstanceIDFromInstance_Public_Int32_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, 100687522);
      ParticlePool.NativeMethodInfoPtr_ReturnInstance_Public_Void_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, 100687523);
      ParticlePool.NativeMethodInfoPtr_WarmupPrefab_Public_Void_GameObject_byref_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, 100687524);
      ParticlePool.NativeMethodInfoPtr_InstantiatePrefab_Private_GameObject_GameObject_Single_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, 100687525);
      ParticlePool.NativeMethodInfoPtr_ValidateParticleSettings_Private_Static_Void_ParticleSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, 100687526);
      ParticlePool.NativeMethodInfoPtr_Clear_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ParticlePool>.NativeClassPtr, 100687527);
    }

    public ParticlePool(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int OutsideVision
    {
      get
      {
        int outsideVision;
        IL2CPP.il2cpp_field_static_get_value(ParticlePool.NativeFieldInfoPtr_OutsideVision, (void*) &outsideVision);
        return outsideVision;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlePool.NativeFieldInfoPtr_OutsideVision, (void*) &value);
      }
    }

    public static unsafe bool UseParticlePooling
    {
      get
      {
        bool useParticlePooling;
        IL2CPP.il2cpp_field_static_get_value(ParticlePool.NativeFieldInfoPtr_UseParticlePooling, (void*) &useParticlePooling);
        return useParticlePooling;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlePool.NativeFieldInfoPtr_UseParticlePooling, (void*) &value);
      }
    }

    public unsafe Transform Parent
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr_Parent));
        return pointer == System.IntPtr.Zero ? (Transform) null : new Transform(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr_Parent), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, Queue<int>> _PrefabToInstanceQueue
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr__PrefabToInstanceQueue));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, Queue<int>>) null : new Dictionary<int, Queue<int>>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr__PrefabToInstanceQueue), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, int> _InstanceToPrefab
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr__InstanceToPrefab));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, int>) null : new Dictionary<int, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr__InstanceToPrefab), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<int, GameObject> _InstanceIdToGameObject
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr__InstanceIdToGameObject));
        return pointer == System.IntPtr.Zero ? (Dictionary<int, GameObject>) null : new Dictionary<int, GameObject>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr__InstanceIdToGameObject), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe MaterialPropertyBlock _HideOutsideVisionBlock
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr__HideOutsideVisionBlock));
        return pointer == System.IntPtr.Zero ? (MaterialPropertyBlock) null : new MaterialPropertyBlock(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr__HideOutsideVisionBlock), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe List<Renderer> _Renderers
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlePool.NativeFieldInfoPtr__Renderers, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<Renderer>) null : new List<Renderer>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlePool.NativeFieldInfoPtr__Renderers, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe List<TrailRenderer> _TrailRenderers
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ParticlePool.NativeFieldInfoPtr__TrailRenderers, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (List<TrailRenderer>) null : new List<TrailRenderer>(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ParticlePool.NativeFieldInfoPtr__TrailRenderers, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe int PKillerProp
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr_PKillerProp));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr_PKillerProp)) = value;
      }
    }

    public unsafe int SeqLifetimeProp
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr_SeqLifetimeProp));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr_SeqLifetimeProp)) = value;
      }
    }

    public unsafe int SeqGLifetimeProp
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr_SeqGLifetimeProp));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ParticlePool.NativeFieldInfoPtr_SeqGLifetimeProp)) = value;
      }
    }
  }
}
