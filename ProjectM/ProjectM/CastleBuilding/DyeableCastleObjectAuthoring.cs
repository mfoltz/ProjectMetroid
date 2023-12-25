// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.DyeableCastleObjectAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class DyeableCastleObjectAuthoring : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatch;
    private static readonly System.IntPtr NativeFieldInfoPtr_ColorSwatchSetupFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetupFlags;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129089, XrefRangeEnd = 1129187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(DyeableCastleObjectAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129187, XrefRangeEnd = 1129191, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DyeableCastleObjectAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129191, XrefRangeEnd = 1129199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DyeableCastleObjectAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeableCastleObjectAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DyeableCastleObjectAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DyeableCastleObjectAuthoring()
    {
      Il2CppClassPointerStore<DyeableCastleObjectAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (DyeableCastleObjectAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeableCastleObjectAuthoring>.NativeClassPtr);
      DyeableCastleObjectAuthoring.NativeFieldInfoPtr_ColorSwatch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring>.NativeClassPtr, nameof (ColorSwatch));
      DyeableCastleObjectAuthoring.NativeFieldInfoPtr_ColorSwatchSetupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring>.NativeClassPtr, nameof (ColorSwatchSetupFlags));
      DyeableCastleObjectAuthoring.NativeFieldInfoPtr_SetupFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring>.NativeClassPtr, nameof (SetupFlags));
      DyeableCastleObjectAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableCastleObjectAuthoring>.NativeClassPtr, 100689736);
      DyeableCastleObjectAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableCastleObjectAuthoring>.NativeClassPtr, 100689737);
      DyeableCastleObjectAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableCastleObjectAuthoring>.NativeClassPtr, 100689738);
    }

    public DyeableCastleObjectAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe BuildMenuDyeSwatchCollectionAsset ColorSwatch
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring.NativeFieldInfoPtr_ColorSwatch));
        return pointer == System.IntPtr.Zero ? (BuildMenuDyeSwatchCollectionAsset) null : new BuildMenuDyeSwatchCollectionAsset(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring.NativeFieldInfoPtr_ColorSwatch), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SwatchSetupFlags> ColorSwatchSetupFlags
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring.NativeFieldInfoPtr_ColorSwatchSetupFlags));
        return pointer == System.IntPtr.Zero ? (List<SwatchSetupFlags>) null : new List<SwatchSetupFlags>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring.NativeFieldInfoPtr_ColorSwatchSetupFlags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<SetupFlag> SetupFlags
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring.NativeFieldInfoPtr_SetupFlags));
        return pointer == System.IntPtr.Zero ? (List<SetupFlag>) null : new List<SetupFlag>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DyeableCastleObjectAuthoring.NativeFieldInfoPtr_SetupFlags), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.CastleBuilding.DyeableCastleObjectAuthoring/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__3_0_Internal_Int32_SwatchSetupFlags_SwatchSetupFlags_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DyeableCastleObjectAuthoring.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DyeableCastleObjectAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129087, XrefRangeEnd = 1129089, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe int _Convert_b__3_0(SwatchSetupFlags x, SwatchSetupFlags y)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) y);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DyeableCastleObjectAuthoring.__c.NativeMethodInfoPtr__Convert_b__3_0_Internal_Int32_SwatchSetupFlags_SwatchSetupFlags_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<DyeableCastleObjectAuthoring.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DyeableCastleObjectAuthoring>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DyeableCastleObjectAuthoring.__c>.NativeClassPtr);
        DyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring.__c>.NativeClassPtr, "<>9");
        DyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DyeableCastleObjectAuthoring.__c>.NativeClassPtr, "<>9__3_0");
        DyeableCastleObjectAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableCastleObjectAuthoring.__c>.NativeClassPtr, 100689740);
        DyeableCastleObjectAuthoring.__c.NativeMethodInfoPtr__Convert_b__3_0_Internal_Int32_SwatchSetupFlags_SwatchSetupFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DyeableCastleObjectAuthoring.__c>.NativeClassPtr, 100689741);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe DyeableCastleObjectAuthoring.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DyeableCastleObjectAuthoring.__c) null : new DyeableCastleObjectAuthoring.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Comparison<SwatchSetupFlags> __9__3_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Comparison<SwatchSetupFlags>) null : new Il2CppSystem.Comparison<SwatchSetupFlags>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
