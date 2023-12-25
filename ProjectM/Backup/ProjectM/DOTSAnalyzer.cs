// Decompiled with JetBrains decompiler
// Type: ProjectM.DOTSAnalyzer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public static class DOTSAnalyzer : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_GetArchetypeSizeAnalysisInfo_Public_Static_String_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintArchetypeSizeAnalysis_Public_Static_Void_Entity_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_PrintLatestComponentLastTouchedBySystem_Public_Static_Void_Entity_EntityManager_0;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 993655, RefRangeEnd = 993657, XrefRangeStart = 993557, XrefRangeEnd = 993655, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetArchetypeSizeAnalysisInfo(
      Entity entity,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(DOTSAnalyzer.NativeMethodInfoPtr_GetArchetypeSizeAnalysisInfo_Public_Static_String_Entity_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993657, XrefRangeEnd = 993662, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PrintArchetypeSizeAnalysis(Entity entity, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DOTSAnalyzer.NativeMethodInfoPtr_PrintArchetypeSizeAnalysis_Public_Static_Void_Entity_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 993662, XrefRangeEnd = 993740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void PrintLatestComponentLastTouchedBySystem(
      Entity entity,
      EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DOTSAnalyzer.NativeMethodInfoPtr_PrintLatestComponentLastTouchedBySystem_Public_Static_Void_Entity_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DOTSAnalyzer()
    {
      Il2CppClassPointerStore<DOTSAnalyzer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DOTSAnalyzer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTSAnalyzer>.NativeClassPtr);
      DOTSAnalyzer.NativeMethodInfoPtr_GetArchetypeSizeAnalysisInfo_Public_Static_String_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTSAnalyzer>.NativeClassPtr, 100676721);
      DOTSAnalyzer.NativeMethodInfoPtr_PrintArchetypeSizeAnalysis_Public_Static_Void_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTSAnalyzer>.NativeClassPtr, 100676722);
      DOTSAnalyzer.NativeMethodInfoPtr_PrintLatestComponentLastTouchedBySystem_Public_Static_Void_Entity_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTSAnalyzer>.NativeClassPtr, 100676723);
    }

    public DOTSAnalyzer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct TypeWithInfo
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Type;
      private static readonly System.IntPtr NativeFieldInfoPtr_TypeInfo;
      [FieldOffset(0)]
      public ComponentType Type;
      [FieldOffset(8)]
      public TypeManager.TypeInfo TypeInfo;

      static TypeWithInfo()
      {
        Il2CppClassPointerStore<DOTSAnalyzer.TypeWithInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTSAnalyzer>.NativeClassPtr, nameof (TypeWithInfo));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTSAnalyzer.TypeWithInfo>.NativeClassPtr);
        DOTSAnalyzer.TypeWithInfo.NativeFieldInfoPtr_Type = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTSAnalyzer.TypeWithInfo>.NativeClassPtr, nameof (Type));
        DOTSAnalyzer.TypeWithInfo.NativeFieldInfoPtr_TypeInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTSAnalyzer.TypeWithInfo>.NativeClassPtr, nameof (TypeInfo));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DOTSAnalyzer.TypeWithInfo>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.DOTSAnalyzer/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__1_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetArchetypeSizeAnalysisInfo_b__1_0_Internal_Int32_TypeWithInfo_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__GetArchetypeSizeAnalysisInfo_b__1_1_Internal_Int32_TypeWithInfo_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DOTSAnalyzer.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(DOTSAnalyzer.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public unsafe int _GetArchetypeSizeAnalysisInfo_b__1_0(DOTSAnalyzer.TypeWithInfo x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DOTSAnalyzer.__c.NativeMethodInfoPtr__GetArchetypeSizeAnalysisInfo_b__1_0_Internal_Int32_TypeWithInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      public unsafe int _GetArchetypeSizeAnalysisInfo_b__1_1(DOTSAnalyzer.TypeWithInfo x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &x;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DOTSAnalyzer.__c.NativeMethodInfoPtr__GetArchetypeSizeAnalysisInfo_b__1_1_Internal_Int32_TypeWithInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static __c()
      {
        Il2CppClassPointerStore<DOTSAnalyzer.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DOTSAnalyzer>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DOTSAnalyzer.__c>.NativeClassPtr);
        DOTSAnalyzer.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTSAnalyzer.__c>.NativeClassPtr, "<>9");
        DOTSAnalyzer.__c.NativeFieldInfoPtr___9__1_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTSAnalyzer.__c>.NativeClassPtr, "<>9__1_0");
        DOTSAnalyzer.__c.NativeFieldInfoPtr___9__1_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DOTSAnalyzer.__c>.NativeClassPtr, "<>9__1_1");
        DOTSAnalyzer.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTSAnalyzer.__c>.NativeClassPtr, 100676725);
        DOTSAnalyzer.__c.NativeMethodInfoPtr__GetArchetypeSizeAnalysisInfo_b__1_0_Internal_Int32_TypeWithInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTSAnalyzer.__c>.NativeClassPtr, 100676726);
        DOTSAnalyzer.__c.NativeMethodInfoPtr__GetArchetypeSizeAnalysisInfo_b__1_1_Internal_Int32_TypeWithInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DOTSAnalyzer.__c>.NativeClassPtr, 100676727);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe DOTSAnalyzer.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DOTSAnalyzer.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (DOTSAnalyzer.__c) null : new DOTSAnalyzer.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DOTSAnalyzer.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<DOTSAnalyzer.TypeWithInfo, int> __9__1_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DOTSAnalyzer.__c.NativeFieldInfoPtr___9__1_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<DOTSAnalyzer.TypeWithInfo, int>) null : new Il2CppSystem.Func<DOTSAnalyzer.TypeWithInfo, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DOTSAnalyzer.__c.NativeFieldInfoPtr___9__1_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<DOTSAnalyzer.TypeWithInfo, int> __9__1_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(DOTSAnalyzer.__c.NativeFieldInfoPtr___9__1_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<DOTSAnalyzer.TypeWithInfo, int>) null : new Il2CppSystem.Func<DOTSAnalyzer.TypeWithInfo, int>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(DOTSAnalyzer.__c.NativeFieldInfoPtr___9__1_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
