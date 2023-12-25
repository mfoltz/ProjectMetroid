// Decompiled with JetBrains decompiler
// Type: ProjectM.AbsorbBuffComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class AbsorbBuffComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IsSiegeWeaponBuff;
    private static readonly System.IntPtr NativeFieldInfoPtr_StackIncreaseCap;
    private static readonly System.IntPtr NativeFieldInfoPtr_StackIncreaseCapModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealthIncreaseCap;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxHealthCapModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbCap;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbCapPerSpellPower;
    private static readonly System.IntPtr NativeFieldInfoPtr_StackIncreaseAbsorb;
    private static readonly System.IntPtr NativeFieldInfoPtr_StackIncreaseAbsorbModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000436, XrefRangeEnd = 1000462, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbsorbBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000462, XrefRangeEnd = 1000469, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbsorbBuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1000469, XrefRangeEnd = 1000470, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbsorbBuffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbsorbBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbsorbBuffComponent()
    {
      Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AbsorbBuffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr);
      AbsorbBuffComponent.NativeFieldInfoPtr_IsSiegeWeaponBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (IsSiegeWeaponBuff));
      AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (StackIncreaseCap));
      AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseCapModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (StackIncreaseCapModifier));
      AbsorbBuffComponent.NativeFieldInfoPtr_MaxHealthIncreaseCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (MaxHealthIncreaseCap));
      AbsorbBuffComponent.NativeFieldInfoPtr_MaxHealthCapModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (MaxHealthCapModifier));
      AbsorbBuffComponent.NativeFieldInfoPtr_AbsorbCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (AbsorbCap));
      AbsorbBuffComponent.NativeFieldInfoPtr_AbsorbCapPerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (AbsorbCapPerSpellPower));
      AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseAbsorb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (StackIncreaseAbsorb));
      AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseAbsorbModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (StackIncreaseAbsorbModifier));
      AbsorbBuffComponent.NativeFieldInfoPtr_AbsorbModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (AbsorbModifier));
      AbsorbBuffComponent.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (SpellMods));
      AbsorbBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, 100677416);
      AbsorbBuffComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, 100677417);
      AbsorbBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, 100677418);
    }

    public AbsorbBuffComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IsSiegeWeaponBuff
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_IsSiegeWeaponBuff));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_IsSiegeWeaponBuff)) = value;
      }
    }

    public unsafe bool StackIncreaseCap
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseCap));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseCap)) = value;
      }
    }

    public unsafe float StackIncreaseCapModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseCapModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseCapModifier)) = value;
      }
    }

    public unsafe bool MaxHealthIncreaseCap
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_MaxHealthIncreaseCap));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_MaxHealthIncreaseCap)) = value;
      }
    }

    public unsafe float MaxHealthCapModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_MaxHealthCapModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_MaxHealthCapModifier)) = value;
      }
    }

    public unsafe float AbsorbCap
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_AbsorbCap));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_AbsorbCap)) = value;
      }
    }

    public unsafe float AbsorbCapPerSpellPower
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_AbsorbCapPerSpellPower));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_AbsorbCapPerSpellPower)) = value;
      }
    }

    public unsafe bool StackIncreaseAbsorb
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseAbsorb));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseAbsorb)) = value;
      }
    }

    public unsafe float StackIncreaseAbsorbModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseAbsorbModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_StackIncreaseAbsorbModifier)) = value;
      }
    }

    public unsafe float AbsorbModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_AbsorbModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_AbsorbModifier)) = value;
      }
    }

    public AbsorbBuffComponent.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_SpellMods);
        return new AbsorbBuffComponent.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbsorbBuffComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbsorbBuffComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbCap;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbCapPerSpellPower;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbCapPerMaxHealth;
      private static readonly System.IntPtr NativeFieldInfoPtr_AbsorbModifier;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<AbsorbBuffComponent.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbsorbBuffComponent>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbsorbBuffComponent.SpellModsAuthoring>.NativeClassPtr);
        AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbCap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent.SpellModsAuthoring>.NativeClassPtr, nameof (AbsorbCap));
        AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbCapPerSpellPower = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent.SpellModsAuthoring>.NativeClassPtr, nameof (AbsorbCapPerSpellPower));
        AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbCapPerMaxHealth = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent.SpellModsAuthoring>.NativeClassPtr, nameof (AbsorbCapPerMaxHealth));
        AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbsorbBuffComponent.SpellModsAuthoring>.NativeClassPtr, nameof (AbsorbModifier));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbsorbBuffComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbsorbBuffComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> AbsorbCap
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbCap));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbCap), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> AbsorbCapPerSpellPower
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbCapPerSpellPower));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbCapPerSpellPower), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> AbsorbCapPerMaxHealth
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbCapPerMaxHealth));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbCapPerMaxHealth), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> AbsorbModifier
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbModifier));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbsorbBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_AbsorbModifier), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
