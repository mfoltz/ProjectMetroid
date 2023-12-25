// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.HybridDyeableCastleObjectAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Hybrid;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.CastleBuilding
{
  public class HybridDyeableCastleObjectAuthoring : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_TryGetMinColorChoices_Private_Boolean_byref_Byte_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129754, XrefRangeEnd = 1129758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), HybridDyeableCastleObjectAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129758, XrefRangeEnd = 1129769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1129813, RefRangeEnd = 1129814, XrefRangeStart = 1129769, XrefRangeEnd = 1129813, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool TryGetMinColorChoices(out byte result)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref result;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectAuthoring.NativeMethodInfoPtr_TryGetMinColorChoices_Private_Boolean_byref_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe HybridDyeableCastleObjectAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static HybridDyeableCastleObjectAuthoring()
    {
      Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (HybridDyeableCastleObjectAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring>.NativeClassPtr);
      HybridDyeableCastleObjectAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring>.NativeClassPtr, 100689765);
      HybridDyeableCastleObjectAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring>.NativeClassPtr, 100689766);
      HybridDyeableCastleObjectAuthoring.NativeMethodInfoPtr_TryGetMinColorChoices_Private_Boolean_byref_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring>.NativeClassPtr, 100689767);
      HybridDyeableCastleObjectAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring>.NativeClassPtr, 100689768);
    }

    public HybridDyeableCastleObjectAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [ObfuscatedName("ProjectM.CastleBuilding.HybridDyeableCastleObjectAuthoring/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryGetMinColorChoices_b__2_0_Internal_HybridDyeableCastleObjectComponent_HybridModelTransformComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__TryGetMinColorChoices_b__2_1_Internal_Int32_HybridDyeableCastleObjectComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1129750, XrefRangeEnd = 1129754, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe HybridDyeableCastleObjectComponent _TryGetMinColorChoices_b__2_0(
        HybridModelTransformComponent x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectAuthoring.__c.NativeMethodInfoPtr__TryGetMinColorChoices_b__2_0_Internal_HybridDyeableCastleObjectComponent_HybridModelTransformComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (HybridDyeableCastleObjectComponent) null : new HybridDyeableCastleObjectComponent(pointer);
      }

      [CallerCount(0)]
      public unsafe int _TryGetMinColorChoices_b__2_1(HybridDyeableCastleObjectComponent x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(HybridDyeableCastleObjectAuthoring.__c.NativeMethodInfoPtr__TryGetMinColorChoices_b__2_1_Internal_Int32_HybridDyeableCastleObjectComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring.__c>.NativeClassPtr);
        HybridDyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring.__c>.NativeClassPtr, "<>9");
        HybridDyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring.__c>.NativeClassPtr, "<>9__2_0");
        HybridDyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring.__c>.NativeClassPtr, "<>9__2_1");
        HybridDyeableCastleObjectAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring.__c>.NativeClassPtr, 100689770);
        HybridDyeableCastleObjectAuthoring.__c.NativeMethodInfoPtr__TryGetMinColorChoices_b__2_0_Internal_HybridDyeableCastleObjectComponent_HybridModelTransformComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring.__c>.NativeClassPtr, 100689771);
        HybridDyeableCastleObjectAuthoring.__c.NativeMethodInfoPtr__TryGetMinColorChoices_b__2_1_Internal_Int32_HybridDyeableCastleObjectComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<HybridDyeableCastleObjectAuthoring.__c>.NativeClassPtr, 100689772);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe HybridDyeableCastleObjectAuthoring.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HybridDyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (HybridDyeableCastleObjectAuthoring.__c) null : new HybridDyeableCastleObjectAuthoring.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HybridDyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<HybridModelTransformComponent, HybridDyeableCastleObjectComponent> __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HybridDyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<HybridModelTransformComponent, HybridDyeableCastleObjectComponent>) null : new Il2CppSystem.Func<HybridModelTransformComponent, HybridDyeableCastleObjectComponent>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HybridDyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<HybridDyeableCastleObjectComponent, int> __9__2_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(HybridDyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9__2_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<HybridDyeableCastleObjectComponent, int>) null : new Il2CppSystem.Func<HybridDyeableCastleObjectComponent, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(HybridDyeableCastleObjectAuthoring.__c.NativeFieldInfoPtr___9__2_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
