// Decompiled with JetBrains decompiler
// Type: ScaleCapeLegColliders
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
public class ScaleCapeLegColliders : MonoBehaviour
{
  private static readonly System.IntPtr NativeFieldInfoPtr_MasterSet;
  private static readonly System.IntPtr NativeFieldInfoPtr_SkinTightVariation;
  private static readonly System.IntPtr NativeFieldInfoPtr_SmallArmourVariation;
  private static readonly System.IntPtr NativeFieldInfoPtr_LargeArmourVariation;
  private static readonly System.IntPtr NativeFieldInfoPtr_SkirtsVariation;
  private static readonly System.IntPtr NativeFieldInfoPtr__SizeSets;
  private static readonly System.IntPtr NativeFieldInfoPtr__LastSizeSet;
  private static readonly System.IntPtr NativeMethodInfoPtr_Awake_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TransferColliderSetSettings_Private_Void_ColliderSet_ColliderSet_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_TransferIndividualColliderSettings_Private_Void_CapsuleCollider_CapsuleCollider_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_SetSize_Public_Void_Int32_0;
  private static readonly System.IntPtr NativeMethodInfoPtr_ReinitialzeSizeSets_Public_Void_0;
  private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921297, XrefRangeEnd = 921307, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Awake()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScaleCapeLegColliders.NativeMethodInfoPtr_Awake_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921307, XrefRangeEnd = 921329, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void Update()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScaleCapeLegColliders.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(1)]
  [CachedScanResults(RefRangeStart = 921334, RefRangeEnd = 921335, XrefRangeStart = 921329, XrefRangeEnd = 921334, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TransferColliderSetSettings(
    ScaleCapeLegColliders.ColliderSet master,
    ScaleCapeLegColliders.ColliderSet slave)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) master));
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) slave));
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScaleCapeLegColliders.NativeMethodInfoPtr_TransferColliderSetSettings_Private_Void_ColliderSet_ColliderSet_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(14)]
  [CachedScanResults(RefRangeStart = 921359, RefRangeEnd = 921373, XrefRangeStart = 921335, XrefRangeEnd = 921359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void TransferIndividualColliderSettings(
    CapsuleCollider master,
    CapsuleCollider slave)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[2];
    numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) master);
    *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) slave);
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScaleCapeLegColliders.NativeMethodInfoPtr_TransferIndividualColliderSettings_Private_Void_CapsuleCollider_CapsuleCollider_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921373, XrefRangeEnd = 921374, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void SetSize(int size)
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = stackalloc System.IntPtr[1];
    numPtr[0] = (System.IntPtr) &size;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScaleCapeLegColliders.NativeMethodInfoPtr_SetSize_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe void ReinitialzeSizeSets()
  {
    IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScaleCapeLegColliders.NativeMethodInfoPtr_ReinitialzeSizeSets_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  [CallerCount(0)]
  [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 921374, XrefRangeEnd = 921382, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
  public unsafe ScaleCapeLegColliders()
    : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr))
  {
    System.IntPtr* numPtr = (System.IntPtr*) null;
    System.IntPtr exc;
    IL2CPP.il2cpp_runtime_invoke(ScaleCapeLegColliders.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
    Il2CppException.RaiseExceptionIfNecessary(exc);
  }

  static ScaleCapeLegColliders()
  {
    Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "", nameof (ScaleCapeLegColliders));
    IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr);
    ScaleCapeLegColliders.NativeFieldInfoPtr_MasterSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, nameof (MasterSet));
    ScaleCapeLegColliders.NativeFieldInfoPtr_SkinTightVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, nameof (SkinTightVariation));
    ScaleCapeLegColliders.NativeFieldInfoPtr_SmallArmourVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, nameof (SmallArmourVariation));
    ScaleCapeLegColliders.NativeFieldInfoPtr_LargeArmourVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, nameof (LargeArmourVariation));
    ScaleCapeLegColliders.NativeFieldInfoPtr_SkirtsVariation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, nameof (SkirtsVariation));
    ScaleCapeLegColliders.NativeFieldInfoPtr__SizeSets = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, nameof (_SizeSets));
    ScaleCapeLegColliders.NativeFieldInfoPtr__LastSizeSet = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, nameof (_LastSizeSet));
    ScaleCapeLegColliders.NativeMethodInfoPtr_Awake_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, 100663671);
    ScaleCapeLegColliders.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, 100663672);
    ScaleCapeLegColliders.NativeMethodInfoPtr_TransferColliderSetSettings_Private_Void_ColliderSet_ColliderSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, 100663673);
    ScaleCapeLegColliders.NativeMethodInfoPtr_TransferIndividualColliderSettings_Private_Void_CapsuleCollider_CapsuleCollider_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, 100663674);
    ScaleCapeLegColliders.NativeMethodInfoPtr_SetSize_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, 100663675);
    ScaleCapeLegColliders.NativeMethodInfoPtr_ReinitialzeSizeSets_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, 100663676);
    ScaleCapeLegColliders.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, 100663677);
  }

  public ScaleCapeLegColliders(System.IntPtr pointer)
    : base(pointer)
  {
  }

  public ScaleCapeLegColliders.ColliderSet MasterSet
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr_MasterSet);
      return new ScaleCapeLegColliders.ColliderSet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr_MasterSet), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public ScaleCapeLegColliders.ColliderSet SkinTightVariation
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr_SkinTightVariation);
      return new ScaleCapeLegColliders.ColliderSet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr_SkinTightVariation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public ScaleCapeLegColliders.ColliderSet SmallArmourVariation
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr_SmallArmourVariation);
      return new ScaleCapeLegColliders.ColliderSet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr_SmallArmourVariation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public ScaleCapeLegColliders.ColliderSet LargeArmourVariation
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr_LargeArmourVariation);
      return new ScaleCapeLegColliders.ColliderSet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr_LargeArmourVariation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public ScaleCapeLegColliders.ColliderSet SkirtsVariation
  {
    get
    {
      System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr_SkirtsVariation);
      return new ScaleCapeLegColliders.ColliderSet(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, data));
    }
    [param: In] set
    {
      __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr_SkirtsVariation), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, (uint&) System.IntPtr.Zero));
    }
  }

  public unsafe List<CapeColliderSizeSet> _SizeSets
  {
    get
    {
      System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr__SizeSets));
      return pointer == System.IntPtr.Zero ? (List<CapeColliderSizeSet>) null : new List<CapeColliderSizeSet>(pointer);
    }
    [param: In] set
    {
      System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr__SizeSets), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
    }
  }

  public unsafe int _LastSizeSet
  {
    get
    {
      return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr__LastSizeSet));
    }
    [param: In] set
    {
      *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.NativeFieldInfoPtr__LastSizeSet)) = value;
    }
  }

  [Serializable]
  public sealed class ColliderSet : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PelvisCollider;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpperLeftLeg;
    private static readonly System.IntPtr NativeFieldInfoPtr_LowerLeftLeg;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpperRightLeg;
    private static readonly System.IntPtr NativeFieldInfoPtr_LowerRightLeg;

    static ColliderSet()
    {
      Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScaleCapeLegColliders>.NativeClassPtr, nameof (ColliderSet));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr);
      ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_PelvisCollider = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, nameof (PelvisCollider));
      ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_UpperLeftLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, nameof (UpperLeftLeg));
      ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_LowerLeftLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, nameof (LowerLeftLeg));
      ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_UpperRightLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, nameof (UpperRightLeg));
      ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_LowerRightLeg = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, nameof (LowerRightLeg));
    }

    public ColliderSet(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ColliderSet()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScaleCapeLegColliders.ColliderSet>.NativeClassPtr, data));
    }

    public unsafe CapsuleCollider PelvisCollider
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_PelvisCollider));
        return pointer == System.IntPtr.Zero ? (CapsuleCollider) null : new CapsuleCollider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_PelvisCollider), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CapsuleCollider UpperLeftLeg
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_UpperLeftLeg));
        return pointer == System.IntPtr.Zero ? (CapsuleCollider) null : new CapsuleCollider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_UpperLeftLeg), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CapsuleCollider LowerLeftLeg
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_LowerLeftLeg));
        return pointer == System.IntPtr.Zero ? (CapsuleCollider) null : new CapsuleCollider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_LowerLeftLeg), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CapsuleCollider UpperRightLeg
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_UpperRightLeg));
        return pointer == System.IntPtr.Zero ? (CapsuleCollider) null : new CapsuleCollider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_UpperRightLeg), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe CapsuleCollider LowerRightLeg
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_LowerRightLeg));
        return pointer == System.IntPtr.Zero ? (CapsuleCollider) null : new CapsuleCollider(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScaleCapeLegColliders.ColliderSet.NativeFieldInfoPtr_LowerRightLeg), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
