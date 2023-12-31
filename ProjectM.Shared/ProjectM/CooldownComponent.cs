// Decompiled with JetBrains decompiler
// Type: ProjectM.CooldownComponent
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
  public class CooldownComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IgnoreCooldownModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxCooldown;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726532, XrefRangeEnd = 726541, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CooldownComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726541, XrefRangeEnd = 726547, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), CooldownComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CooldownComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CooldownComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CooldownComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CooldownComponent()
    {
      Il2CppClassPointerStore<CooldownComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CooldownComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CooldownComponent>.NativeClassPtr);
      CooldownComponent.NativeFieldInfoPtr_IgnoreCooldownModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CooldownComponent>.NativeClassPtr, nameof (IgnoreCooldownModifier));
      CooldownComponent.NativeFieldInfoPtr_MaxCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CooldownComponent>.NativeClassPtr, nameof (MaxCooldown));
      CooldownComponent.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CooldownComponent>.NativeClassPtr, nameof (SpellMods));
      CooldownComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CooldownComponent>.NativeClassPtr, 100664216);
      CooldownComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CooldownComponent>.NativeClassPtr, 100664217);
      CooldownComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CooldownComponent>.NativeClassPtr, 100664218);
    }

    public CooldownComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IgnoreCooldownModifier
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CooldownComponent.NativeFieldInfoPtr_IgnoreCooldownModifier));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CooldownComponent.NativeFieldInfoPtr_IgnoreCooldownModifier)) = value;
      }
    }

    public unsafe float MaxCooldown
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CooldownComponent.NativeFieldInfoPtr_MaxCooldown));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CooldownComponent.NativeFieldInfoPtr_MaxCooldown)) = value;
      }
    }

    public CooldownComponent.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CooldownComponent.NativeFieldInfoPtr_SpellMods);
        return new CooldownComponent.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CooldownComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CooldownComponent.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CooldownComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MaxCooldown;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<CooldownComponent.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CooldownComponent>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CooldownComponent.SpellModsAuthoring>.NativeClassPtr);
        CooldownComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxCooldown = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CooldownComponent.SpellModsAuthoring>.NativeClassPtr, nameof (MaxCooldown));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<CooldownComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CooldownComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MaxCooldown
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CooldownComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxCooldown));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CooldownComponent.SpellModsAuthoring.NativeFieldInfoPtr_MaxCooldown), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
