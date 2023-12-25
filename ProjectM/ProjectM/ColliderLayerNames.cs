// Decompiled with JetBrains decompiler
// Type: ProjectM.ColliderLayerNames
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class ColliderLayerNames : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxNumCategories;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultCategoryName;
    private static readonly System.IntPtr NativeFieldInfoPtr_DefaultFormatString;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_DefaultOptions;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_DefaultOptions_Private_Static_get_Il2CppStringArray_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_LoadOptions_Public_Static_Il2CppStringArray_0;

    public static unsafe Il2CppStringArray DefaultOptions
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049567, XrefRangeEnd = 1049594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColliderLayerNames.NativeMethodInfoPtr_get_DefaultOptions_Private_Static_get_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Il2CppStringArray LoadOptions()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ColliderLayerNames.NativeMethodInfoPtr_LoadOptions_Public_Static_Il2CppStringArray_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
    }

    static ColliderLayerNames()
    {
      Il2CppClassPointerStore<ColliderLayerNames>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ColliderLayerNames));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColliderLayerNames>.NativeClassPtr);
      ColliderLayerNames.NativeFieldInfoPtr_MaxNumCategories = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderLayerNames>.NativeClassPtr, nameof (MaxNumCategories));
      ColliderLayerNames.NativeFieldInfoPtr_DefaultCategoryName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderLayerNames>.NativeClassPtr, nameof (DefaultCategoryName));
      ColliderLayerNames.NativeFieldInfoPtr_DefaultFormatString = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderLayerNames>.NativeClassPtr, nameof (DefaultFormatString));
      ColliderLayerNames.NativeFieldInfoPtr_m_DefaultOptions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderLayerNames>.NativeClassPtr, nameof (m_DefaultOptions));
      ColliderLayerNames.NativeMethodInfoPtr_get_DefaultOptions_Private_Static_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderLayerNames>.NativeClassPtr, 100682358);
      ColliderLayerNames.NativeMethodInfoPtr_LoadOptions_Public_Static_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderLayerNames>.NativeClassPtr, 100682359);
    }

    public ColliderLayerNames(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int MaxNumCategories
    {
      get
      {
        int maxNumCategories;
        IL2CPP.il2cpp_field_static_get_value(ColliderLayerNames.NativeFieldInfoPtr_MaxNumCategories, (void*) &maxNumCategories);
        return maxNumCategories;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ColliderLayerNames.NativeFieldInfoPtr_MaxNumCategories, (void*) &value);
      }
    }

    public static unsafe string DefaultCategoryName
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ColliderLayerNames.NativeFieldInfoPtr_DefaultCategoryName, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ColliderLayerNames.NativeFieldInfoPtr_DefaultCategoryName, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe string DefaultFormatString
    {
      get
      {
        System.IntPtr il2CppString;
        IL2CPP.il2cpp_field_static_get_value(ColliderLayerNames.NativeFieldInfoPtr_DefaultFormatString, (void*) &il2CppString);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ColliderLayerNames.NativeFieldInfoPtr_DefaultFormatString, (void*) IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public static unsafe Il2CppStringArray m_DefaultOptions
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(ColliderLayerNames.NativeFieldInfoPtr_m_DefaultOptions, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppStringArray) null : new Il2CppStringArray(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ColliderLayerNames.NativeFieldInfoPtr_m_DefaultOptions, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [ObfuscatedName("ProjectM.ColliderLayerNames/<>c")]
    [Serializable]
    public sealed class __c : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr___9;
      private static readonly System.IntPtr NativeFieldInfoPtr___9__5_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__get_DefaultOptions_b__5_0_Internal_String_Int32_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ColliderLayerNames.__c>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ColliderLayerNames.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1049561, XrefRangeEnd = 1049567, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe string _get_DefaultOptions_b__5_0(int i)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &i;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ColliderLayerNames.__c.NativeMethodInfoPtr__get_DefaultOptions_b__5_0_Internal_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }

      static __c()
      {
        Il2CppClassPointerStore<ColliderLayerNames.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ColliderLayerNames>.NativeClassPtr, "<>c");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ColliderLayerNames.__c>.NativeClassPtr);
        ColliderLayerNames.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderLayerNames.__c>.NativeClassPtr, "<>9");
        ColliderLayerNames.__c.NativeFieldInfoPtr___9__5_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ColliderLayerNames.__c>.NativeClassPtr, "<>9__5_0");
        ColliderLayerNames.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderLayerNames.__c>.NativeClassPtr, 100682361);
        ColliderLayerNames.__c.NativeMethodInfoPtr__get_DefaultOptions_b__5_0_Internal_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ColliderLayerNames.__c>.NativeClassPtr, 100682362);
      }

      public __c(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public static unsafe ColliderLayerNames.__c __9
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ColliderLayerNames.__c.NativeFieldInfoPtr___9, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (ColliderLayerNames.__c) null : new ColliderLayerNames.__c(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ColliderLayerNames.__c.NativeFieldInfoPtr___9, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public static unsafe Il2CppSystem.Func<int, string> __9__5_0
      {
        get
        {
          System.IntPtr num;
          IL2CPP.il2cpp_field_static_get_value(ColliderLayerNames.__c.NativeFieldInfoPtr___9__5_0, (void*) &num);
          System.IntPtr pointer = num;
          return pointer == System.IntPtr.Zero ? (Il2CppSystem.Func<int, string>) null : new Il2CppSystem.Func<int, string>(pointer);
        }
        [param: In] set
        {
          IL2CPP.il2cpp_field_static_set_value(ColliderLayerNames.__c.NativeFieldInfoPtr___9__5_0, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
