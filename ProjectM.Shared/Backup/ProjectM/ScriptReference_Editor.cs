// Decompiled with JetBrains decompiler
// Type: ProjectM.ScriptReference_Editor
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.Reflection;
using ProjectM.ContentTesting;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  [Serializable]
  public sealed class ScriptReference_Editor : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MethodName;
    private static readonly System.IntPtr NativeFieldInfoPtr_TypeName;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_ScriptMethodReference_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsCompatible_Public_Static_Boolean_Type_MethodInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ContentTest_Public_Static_Void_Component_ScriptReference_Editor_Type_List_1_ContentIssue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetTypeName_Private_Static_String_Type_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726830, RefRangeEnd = 726831, XrefRangeStart = 726824, XrefRangeEnd = 726830, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ScriptMethodReference Convert()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptReference_Editor.NativeMethodInfoPtr_Convert_Public_ScriptMethodReference_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ScriptMethodReference*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726831, XrefRangeEnd = 726875, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool IsCompatible(Il2CppSystem.Type expectedFunctionType, MethodInfo methodInfo)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) expectedFunctionType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) methodInfo);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptReference_Editor.NativeMethodInfoPtr_IsCompatible_Public_Static_Boolean_Type_MethodInfo_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void ContentTest(
      Component c,
      ScriptReference_Editor scriptReference,
      Il2CppSystem.Type delegateType,
      List<ContentIssue> outIssues)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) c);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) scriptReference));
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) delegateType);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) outIssues);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScriptReference_Editor.NativeMethodInfoPtr_ContentTest_Public_Static_Void_Component_ScriptReference_Editor_Type_List_1_ContentIssue_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 726920, RefRangeEnd = 726921, XrefRangeStart = 726875, XrefRangeEnd = 726920, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe string GetTypeName(Il2CppSystem.Type type)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) type);
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ScriptReference_Editor.NativeMethodInfoPtr_GetTypeName_Private_Static_String_Type_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static ScriptReference_Editor()
    {
      Il2CppClassPointerStore<ScriptReference_Editor>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ScriptReference_Editor));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptReference_Editor>.NativeClassPtr);
      ScriptReference_Editor.NativeFieldInfoPtr_MethodName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptReference_Editor>.NativeClassPtr, nameof (MethodName));
      ScriptReference_Editor.NativeFieldInfoPtr_TypeName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptReference_Editor>.NativeClassPtr, nameof (TypeName));
      ScriptReference_Editor.NativeMethodInfoPtr_Convert_Public_ScriptMethodReference_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptReference_Editor>.NativeClassPtr, 100664269);
      ScriptReference_Editor.NativeMethodInfoPtr_IsCompatible_Public_Static_Boolean_Type_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptReference_Editor>.NativeClassPtr, 100664270);
      ScriptReference_Editor.NativeMethodInfoPtr_ContentTest_Public_Static_Void_Component_ScriptReference_Editor_Type_List_1_ContentIssue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptReference_Editor>.NativeClassPtr, 100664271);
      ScriptReference_Editor.NativeMethodInfoPtr_GetTypeName_Private_Static_String_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptReference_Editor>.NativeClassPtr, 100664272);
    }

    public ScriptReference_Editor(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public ScriptReference_Editor()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ScriptReference_Editor>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptReference_Editor>.NativeClassPtr, data));
    }

    public unsafe string MethodName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptReference_Editor.NativeFieldInfoPtr_MethodName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptReference_Editor.NativeFieldInfoPtr_MethodName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string TypeName
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ScriptReference_Editor.NativeFieldInfoPtr_TypeName)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ScriptReference_Editor.NativeFieldInfoPtr_TypeName), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    [ObfuscatedName("ProjectM.ScriptReference_Editor/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3_0;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__3_1;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__IsCompatible_b__3_0_Internal_Type_ParameterInfo_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__IsCompatible_b__3_1_Internal_Type_ParameterInfo_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ScriptReference_Editor.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ScriptReference_Editor.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Il2CppSystem.Type _IsCompatible_b__3_0(ParameterInfo x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptReference_Editor.__c.NativeMethodInfoPtr__IsCompatible_b__3_0_Internal_Type_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Il2CppSystem.Type _IsCompatible_b__3_1(ParameterInfo x)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) x);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ScriptReference_Editor.__c.NativeMethodInfoPtr__IsCompatible_b__3_1_Internal_Type_ParameterInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Type) null : new Il2CppSystem.Type(pointer);
      }

      static __c()
      {
        Il2CppClassPointerStore<ScriptReference_Editor.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptReference_Editor>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptReference_Editor.__c>.NativeClassPtr);
        ScriptReference_Editor.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptReference_Editor.__c>.NativeClassPtr, "<>9");
        ScriptReference_Editor.__c.NativeFieldInfoPtr___9__3_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptReference_Editor.__c>.NativeClassPtr, "<>9__3_0");
        ScriptReference_Editor.__c.NativeFieldInfoPtr___9__3_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptReference_Editor.__c>.NativeClassPtr, "<>9__3_1");
        ScriptReference_Editor.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptReference_Editor.__c>.NativeClassPtr, 100664274);
        ScriptReference_Editor.__c.NativeMethodInfoPtr__IsCompatible_b__3_0_Internal_Type_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptReference_Editor.__c>.NativeClassPtr, 100664275);
        ScriptReference_Editor.__c.NativeMethodInfoPtr__IsCompatible_b__3_1_Internal_Type_ParameterInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptReference_Editor.__c>.NativeClassPtr, 100664276);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ScriptReference_Editor.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ScriptReference_Editor.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ScriptReference_Editor.__c) null : new ScriptReference_Editor.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ScriptReference_Editor.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ParameterInfo, Il2CppSystem.Type> __9__3_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ScriptReference_Editor.__c.NativeFieldInfoPtr___9__3_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ParameterInfo, Il2CppSystem.Type>) null : new Il2CppSystem.Func<ParameterInfo, Il2CppSystem.Type>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ScriptReference_Editor.__c.NativeFieldInfoPtr___9__3_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<ParameterInfo, Il2CppSystem.Type> __9__3_1
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ScriptReference_Editor.__c.NativeFieldInfoPtr___9__3_1, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<ParameterInfo, Il2CppSystem.Type>) null : new Il2CppSystem.Func<ParameterInfo, Il2CppSystem.Type>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ScriptReference_Editor.__c.NativeFieldInfoPtr___9__3_1, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
