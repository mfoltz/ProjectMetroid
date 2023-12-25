// Decompiled with JetBrains decompiler
// Type: ProjectM.LifetimeAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class LifetimeAuthoring : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_IncreaseLifetimeByStacks;
    private static readonly System.IntPtr NativeFieldInfoPtr_LifeTimeIncreaseModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_UseRandomDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_MinDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxDuration;
    private static readonly System.IntPtr NativeFieldInfoPtr_EndAction;
    private static readonly System.IntPtr NativeFieldInfoPtr_UpdateWhenDisabled;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public virtual unsafe IEnumerable<ProjectM.SpellModSettings> SpellModSettings
    {
      [CallerCount(7), CachedScanResults(RefRangeStart = 22398, RefRangeEnd = 22405, XrefRangeStart = 22398, XrefRangeEnd = 22405, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(LifetimeAuthoring.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (IEnumerable<ProjectM.SpellModSettings>) null : new IEnumerable<ProjectM.SpellModSettings>(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024575, XrefRangeEnd = 1024592, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(LifetimeAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024592, XrefRangeEnd = 1024596, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), LifetimeAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1024596, XrefRangeEnd = 1024597, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe LifetimeAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(LifetimeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static LifetimeAuthoring()
    {
      Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (LifetimeAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr);
      LifetimeAuthoring.NativeFieldInfoPtr_IncreaseLifetimeByStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, nameof (IncreaseLifetimeByStacks));
      LifetimeAuthoring.NativeFieldInfoPtr_LifeTimeIncreaseModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, nameof (LifeTimeIncreaseModifier));
      LifetimeAuthoring.NativeFieldInfoPtr_UseRandomDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, nameof (UseRandomDuration));
      LifetimeAuthoring.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, nameof (Duration));
      LifetimeAuthoring.NativeFieldInfoPtr_MinDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, nameof (MinDuration));
      LifetimeAuthoring.NativeFieldInfoPtr_MaxDuration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, nameof (MaxDuration));
      LifetimeAuthoring.NativeFieldInfoPtr_EndAction = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, nameof (EndAction));
      LifetimeAuthoring.NativeFieldInfoPtr_UpdateWhenDisabled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, nameof (UpdateWhenDisabled));
      LifetimeAuthoring.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, nameof (SpellMods));
      LifetimeAuthoring.NativeMethodInfoPtr_get_SpellModSettings_Public_Virtual_Final_New_get_IEnumerable_1_SpellModSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, 100680032);
      LifetimeAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, 100680033);
      LifetimeAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, 100680034);
      LifetimeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, 100680035);
    }

    public LifetimeAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool IncreaseLifetimeByStacks
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_IncreaseLifetimeByStacks));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_IncreaseLifetimeByStacks)) = value;
      }
    }

    public unsafe float LifeTimeIncreaseModifier
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_LifeTimeIncreaseModifier));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_LifeTimeIncreaseModifier)) = value;
      }
    }

    public unsafe bool UseRandomDuration
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_UseRandomDuration));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_UseRandomDuration)) = value;
      }
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_Duration)) = value;
      }
    }

    public unsafe float MinDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_MinDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_MinDuration)) = value;
      }
    }

    public unsafe float MaxDuration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_MaxDuration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_MaxDuration)) = value;
      }
    }

    public unsafe LifeTimeEndAction EndAction
    {
      get
      {
        return *(LifeTimeEndAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_EndAction));
      }
      [param: In] set
      {
        *(LifeTimeEndAction*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_EndAction)) = value;
      }
    }

    public unsafe bool UpdateWhenDisabled
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_UpdateWhenDisabled));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_UpdateWhenDisabled)) = value;
      }
    }

    public LifetimeAuthoring.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_SpellMods);
        return new LifetimeAuthoring.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LifetimeAuthoring.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LifetimeAuthoring.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Duration;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<LifetimeAuthoring.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<LifetimeAuthoring>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LifetimeAuthoring.SpellModsAuthoring>.NativeClassPtr);
        LifetimeAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LifetimeAuthoring.SpellModsAuthoring>.NativeClassPtr, nameof (Duration));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<LifetimeAuthoring.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LifetimeAuthoring.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> Duration
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Duration));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(LifetimeAuthoring.SpellModsAuthoring.NativeFieldInfoPtr_Duration), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
