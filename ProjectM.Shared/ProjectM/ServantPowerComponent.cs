// Decompiled with JetBrains decompiler
// Type: ProjectM.ServantPowerComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ServantPowerComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantHealthSettings;
    private static readonly System.IntPtr NativeFieldInfoPtr_ServantDamageSettings;
    private static readonly System.IntPtr NativeMethodInfoPtr_ConvertPowerAsset_Private_ServantPowerData_Unit_StatsSettings_Asset_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 740760, RefRangeEnd = 740762, XrefRangeStart = 740720, XrefRangeEnd = 740760, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantPowerData ConvertPowerAsset(Unit_StatsSettings_Asset asset)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPowerComponent.NativeMethodInfoPtr_ConvertPowerAsset_Private_ServantPowerData_Unit_StatsSettings_Asset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServantPowerData*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740762, XrefRangeEnd = 740770, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ServantPowerComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740770, XrefRangeEnd = 740774, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ServantPowerComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServantPowerComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantPowerComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ServantPowerComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ServantPowerComponent()
    {
      Il2CppClassPointerStore<ServantPowerComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ServantPowerComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantPowerComponent>.NativeClassPtr);
      ServantPowerComponent.NativeFieldInfoPtr_ServantHealthSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPowerComponent>.NativeClassPtr, nameof (ServantHealthSettings));
      ServantPowerComponent.NativeFieldInfoPtr_ServantDamageSettings = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPowerComponent>.NativeClassPtr, nameof (ServantDamageSettings));
      ServantPowerComponent.NativeMethodInfoPtr_ConvertPowerAsset_Private_ServantPowerData_Unit_StatsSettings_Asset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPowerComponent>.NativeClassPtr, 100665359);
      ServantPowerComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPowerComponent>.NativeClassPtr, 100665360);
      ServantPowerComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPowerComponent>.NativeClassPtr, 100665361);
      ServantPowerComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPowerComponent>.NativeClassPtr, 100665362);
    }

    public ServantPowerComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Unit_StatsSettings_Asset ServantHealthSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPowerComponent.NativeFieldInfoPtr_ServantHealthSettings));
        return pointer == System.IntPtr.Zero ? (Unit_StatsSettings_Asset) null : new Unit_StatsSettings_Asset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPowerComponent.NativeFieldInfoPtr_ServantHealthSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Unit_StatsSettings_Asset ServantDamageSettings
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ServantPowerComponent.NativeFieldInfoPtr_ServantDamageSettings));
        return pointer == System.IntPtr.Zero ? (Unit_StatsSettings_Asset) null : new Unit_StatsSettings_Asset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ServantPowerComponent.NativeFieldInfoPtr_ServantDamageSettings), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.ServantPowerComponent/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ConvertPowerAsset_b__2_0_Internal_Boolean_Unit_StatsSettings_EditorData_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ConvertPowerAsset_b__2_1_Internal_ServantPowerData_Unit_StatsSettings_EditorData_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ServantPowerComponent.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ServantPowerComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe bool _ConvertPowerAsset_b__2_0(Unit_StatsSettings_EditorData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPowerComponent.__c.NativeMethodInfoPtr__ConvertPowerAsset_b__2_0_Internal_Boolean_Unit_StatsSettings_EditorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740719, XrefRangeEnd = 740720, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ServantPowerData _ConvertPowerAsset_b__2_1(Unit_StatsSettings_EditorData data)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) data);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ServantPowerComponent.__c.NativeMethodInfoPtr__ConvertPowerAsset_b__2_1_Internal_ServantPowerData_Unit_StatsSettings_EditorData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ServantPowerData*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<ServantPowerComponent.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ServantPowerComponent>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ServantPowerComponent.__c>.NativeClassPtr);
        ServantPowerComponent.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPowerComponent.__c>.NativeClassPtr, "<>9");
        ServantPowerComponent.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPowerComponent.__c>.NativeClassPtr, "<>9__2_0");
        ServantPowerComponent.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ServantPowerComponent.__c>.NativeClassPtr, "<>9__2_1");
        ServantPowerComponent.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPowerComponent.__c>.NativeClassPtr, 100665364);
        ServantPowerComponent.__c.NativeMethodInfoPtr__ConvertPowerAsset_b__2_0_Internal_Boolean_Unit_StatsSettings_EditorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPowerComponent.__c>.NativeClassPtr, 100665365);
        ServantPowerComponent.__c.NativeMethodInfoPtr__ConvertPowerAsset_b__2_1_Internal_ServantPowerData_Unit_StatsSettings_EditorData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ServantPowerComponent.__c>.NativeClassPtr, 100665366);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ServantPowerComponent.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantPowerComponent.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ServantPowerComponent.__c) null : new ServantPowerComponent.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantPowerComponent.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Unit_StatsSettings_EditorData, bool> __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantPowerComponent.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Unit_StatsSettings_EditorData, bool>) null : new Il2CppSystem.Func<Unit_StatsSettings_EditorData, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantPowerComponent.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<Unit_StatsSettings_EditorData, ServantPowerData> __9__2_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ServantPowerComponent.__c.NativeFieldInfoPtr___9__2_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<Unit_StatsSettings_EditorData, ServantPowerData>) null : new Il2CppSystem.Func<Unit_StatsSettings_EditorData, ServantPowerData>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ServantPowerComponent.__c.NativeFieldInfoPtr___9__2_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
