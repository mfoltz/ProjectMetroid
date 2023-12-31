// Decompiled with JetBrains decompiler
// Type: ProjectM.AbilityGroupChargesComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

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
  public class AbilityGroupChargesComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_Charges;
    private static readonly System.IntPtr NativeFieldInfoPtr_ChargeUpTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724702, XrefRangeEnd = 724711, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AbilityGroupChargesComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 724711, XrefRangeEnd = 724715, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), AbilityGroupChargesComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AbilityGroupChargesComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbilityGroupChargesComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AbilityGroupChargesComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AbilityGroupChargesComponent()
    {
      Il2CppClassPointerStore<AbilityGroupChargesComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (AbilityGroupChargesComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupChargesComponent>.NativeClassPtr);
      AbilityGroupChargesComponent.NativeFieldInfoPtr_IgnoreCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupChargesComponent>.NativeClassPtr, nameof (IgnoreCooldownModifier));
      AbilityGroupChargesComponent.NativeFieldInfoPtr_Charges = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupChargesComponent>.NativeClassPtr, nameof (Charges));
      AbilityGroupChargesComponent.NativeFieldInfoPtr_ChargeUpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupChargesComponent>.NativeClassPtr, nameof (ChargeUpTime));
      AbilityGroupChargesComponent.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupChargesComponent>.NativeClassPtr, nameof (SpellMods));
      AbilityGroupChargesComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGroupChargesComponent>.NativeClassPtr, 100664107);
      AbilityGroupChargesComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGroupChargesComponent>.NativeClassPtr, 100664108);
      AbilityGroupChargesComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbilityGroupChargesComponent>.NativeClassPtr, 100664109);
    }

    public AbilityGroupChargesComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IgnoreCooldownModifier
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupChargesComponent.NativeFieldInfoPtr_IgnoreCooldownModifier));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupChargesComponent.NativeFieldInfoPtr_IgnoreCooldownModifier)) = value;
      }
    }

    public unsafe int Charges
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupChargesComponent.NativeFieldInfoPtr_Charges));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupChargesComponent.NativeFieldInfoPtr_Charges)) = value;
      }
    }

    public unsafe float ChargeUpTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupChargesComponent.NativeFieldInfoPtr_ChargeUpTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupChargesComponent.NativeFieldInfoPtr_ChargeUpTime)) = value;
      }
    }

    public AbilityGroupChargesComponent.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupChargesComponent.NativeFieldInfoPtr_SpellMods);
        return new AbilityGroupChargesComponent.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityGroupChargesComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupChargesComponent.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityGroupChargesComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ChargeUpTime;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<AbilityGroupChargesComponent.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AbilityGroupChargesComponent>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbilityGroupChargesComponent.SpellModsAuthoring>.NativeClassPtr);
        AbilityGroupChargesComponent.SpellModsAuthoring.NativeFieldInfoPtr_ChargeUpTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbilityGroupChargesComponent.SpellModsAuthoring>.NativeClassPtr, nameof (ChargeUpTime));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<AbilityGroupChargesComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AbilityGroupChargesComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> ChargeUpTime
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupChargesComponent.SpellModsAuthoring.NativeFieldInfoPtr_ChargeUpTime));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(AbilityGroupChargesComponent.SpellModsAuthoring.NativeFieldInfoPtr_ChargeUpTime), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
