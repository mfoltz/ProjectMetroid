// Decompiled with JetBrains decompiler
// Type: ProjectM.VBloodShapeshiftDataAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.Shared;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class VBloodShapeshiftDataAuthoring : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_RequiresUserContentFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_Skins;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042989, XrefRangeEnd = 1043093, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(VBloodShapeshiftDataAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe VBloodShapeshiftDataAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(VBloodShapeshiftDataAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static VBloodShapeshiftDataAuthoring()
    {
      Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (VBloodShapeshiftDataAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring>.NativeClassPtr);
      VBloodShapeshiftDataAuthoring.NativeFieldInfoPtr_RequiresUserContentFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring>.NativeClassPtr, nameof (RequiresUserContentFlags));
      VBloodShapeshiftDataAuthoring.NativeFieldInfoPtr_Skins = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring>.NativeClassPtr, nameof (Skins));
      VBloodShapeshiftDataAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring>.NativeClassPtr, 100681737);
      VBloodShapeshiftDataAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring>.NativeClassPtr, 100681738);
    }

    public VBloodShapeshiftDataAuthoring(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe UserContentFlags RequiresUserContentFlags
    {
      get
      {
        return *(UserContentFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodShapeshiftDataAuthoring.NativeFieldInfoPtr_RequiresUserContentFlags));
      }
      [param: In] set
      {
        *(UserContentFlags*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodShapeshiftDataAuthoring.NativeFieldInfoPtr_RequiresUserContentFlags)) = value;
      }
    }

    public unsafe Il2CppReferenceArray<VBloodShapeshiftDataAuthoring> Skins
    {
      get
      {
        System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(VBloodShapeshiftDataAuthoring.NativeFieldInfoPtr_Skins));
        return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<VBloodShapeshiftDataAuthoring>) null : new Il2CppReferenceArray<VBloodShapeshiftDataAuthoring>(nativeObject);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(VBloodShapeshiftDataAuthoring.NativeFieldInfoPtr_Skins), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.VBloodShapeshiftDataAuthoring/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_1;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_2;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__2_3;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__2_0_Internal_Boolean_VBloodShapeshiftDataAuthoring_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__2_1_Internal___f__AnonymousType1_2_VBloodShapeshiftDataAuthoring_PrefabGuidComponent_VBloodShapeshiftDataAuthoring_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__2_2_Internal_Boolean___f__AnonymousType1_2_VBloodShapeshiftDataAuthoring_PrefabGuidComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__Convert_b__2_3_Internal_PrefabGUID___f__AnonymousType1_2_VBloodShapeshiftDataAuthoring_PrefabGuidComponent_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(VBloodShapeshiftDataAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042967, XrefRangeEnd = 1042971, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _Convert_b__2_0(VBloodShapeshiftDataAuthoring skin)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) skin);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodShapeshiftDataAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_0_Internal_Boolean_VBloodShapeshiftDataAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042971, XrefRangeEnd = 1042980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent> _Convert_b__2_1(
        VBloodShapeshiftDataAuthoring skin)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) skin);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodShapeshiftDataAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_1_Internal___f__AnonymousType1_2_VBloodShapeshiftDataAuthoring_PrefabGuidComponent_VBloodShapeshiftDataAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (__f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent>) null : new __f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent>(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042980, XrefRangeEnd = 1042986, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe bool _Convert_b__2_2(
        __f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent> _param1)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodShapeshiftDataAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_2_Internal_Boolean___f__AnonymousType1_2_VBloodShapeshiftDataAuthoring_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1042986, XrefRangeEnd = 1042989, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe PrefabGUID _Convert_b__2_3(
        __f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent> _param1)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) _param1);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(VBloodShapeshiftDataAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_3_Internal_PrefabGUID___f__AnonymousType1_2_VBloodShapeshiftDataAuthoring_PrefabGuidComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr);
        VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr, "<>9");
        VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr, "<>9__2_0");
        VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr, "<>9__2_1");
        VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr, "<>9__2_2");
        VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr, "<>9__2_3");
        VBloodShapeshiftDataAuthoring.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr, 100681740);
        VBloodShapeshiftDataAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_0_Internal_Boolean_VBloodShapeshiftDataAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr, 100681741);
        VBloodShapeshiftDataAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_1_Internal___f__AnonymousType1_2_VBloodShapeshiftDataAuthoring_PrefabGuidComponent_VBloodShapeshiftDataAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr, 100681742);
        VBloodShapeshiftDataAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_2_Internal_Boolean___f__AnonymousType1_2_VBloodShapeshiftDataAuthoring_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr, 100681743);
        VBloodShapeshiftDataAuthoring.__c.NativeMethodInfoPtr__Convert_b__2_3_Internal_PrefabGUID___f__AnonymousType1_2_VBloodShapeshiftDataAuthoring_PrefabGuidComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<VBloodShapeshiftDataAuthoring.__c>.NativeClassPtr, 100681744);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe VBloodShapeshiftDataAuthoring.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (VBloodShapeshiftDataAuthoring.__c) null : new VBloodShapeshiftDataAuthoring.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<VBloodShapeshiftDataAuthoring, bool> __9__2_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<VBloodShapeshiftDataAuthoring, bool>) null : new Il2CppSystem.Func<VBloodShapeshiftDataAuthoring, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<VBloodShapeshiftDataAuthoring, __f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent>> __9__2_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<VBloodShapeshiftDataAuthoring, __f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent>>) null : new Il2CppSystem.Func<VBloodShapeshiftDataAuthoring, __f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent>>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<__f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent>, bool> __9__2_2
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_2, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<__f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent>, bool>) null : new Il2CppSystem.Func<__f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent>, bool>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_2, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<__f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent>, PrefabGUID> __9__2_3
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_3, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<__f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent>, PrefabGUID>) null : new Il2CppSystem.Func<__f__AnonymousType1<VBloodShapeshiftDataAuthoring, PrefabGuidComponent>, PrefabGUID>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(VBloodShapeshiftDataAuthoring.__c.NativeFieldInfoPtr___9__2_3, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
