// Decompiled with JetBrains decompiler
// Type: ProjectM.Fishy
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using ProjectM.ContentTesting;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class Fishy : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FishyComments;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe Fishy()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fishy>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(Fishy.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static Fishy()
    {
      Il2CppClassPointerStore<Fishy>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (Fishy));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fishy>.NativeClassPtr);
      Fishy.NativeFieldInfoPtr_FishyComments = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fishy>.NativeClassPtr, nameof (FishyComments));
      Fishy.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fishy>.NativeClassPtr, 100676864);
    }

    public Fishy(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Fishy.FishyCommentArray FishyComments
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fishy.NativeFieldInfoPtr_FishyComments));
        return pointer == System.IntPtr.Zero ? (Fishy.FishyCommentArray) null : new Fishy.FishyCommentArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Fishy.NativeFieldInfoPtr_FishyComments), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class FishyComment : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Description;
      private static readonly System.IntPtr NativeFieldInfoPtr_Reporter;
      private static readonly System.IntPtr NativeFieldInfoPtr_Severity;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe FishyComment()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fishy.FishyComment>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Fishy.FishyComment.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static FishyComment()
      {
        Il2CppClassPointerStore<Fishy.FishyComment>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fishy>.NativeClassPtr, nameof (FishyComment));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fishy.FishyComment>.NativeClassPtr);
        Fishy.FishyComment.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fishy.FishyComment>.NativeClassPtr, nameof (Description));
        Fishy.FishyComment.NativeFieldInfoPtr_Reporter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fishy.FishyComment>.NativeClassPtr, nameof (Reporter));
        Fishy.FishyComment.NativeFieldInfoPtr_Severity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Fishy.FishyComment>.NativeClassPtr, nameof (Severity));
        Fishy.FishyComment.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fishy.FishyComment>.NativeClassPtr, 100676865);
      }

      public FishyComment(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe string Description
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fishy.FishyComment.NativeFieldInfoPtr_Description)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Fishy.FishyComment.NativeFieldInfoPtr_Description), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string Reporter
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fishy.FishyComment.NativeFieldInfoPtr_Reporter)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(Fishy.FishyComment.NativeFieldInfoPtr_Reporter), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe IssueSeverity Severity
      {
        get
        {
          return *(IssueSeverity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fishy.FishyComment.NativeFieldInfoPtr_Severity));
        }
        [param: In] set
        {
          *(IssueSeverity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(Fishy.FishyComment.NativeFieldInfoPtr_Severity)) = value;
        }
      }
    }

    [Serializable]
    public class FishyCommentArray : ReorderableArray<Fishy.FishyComment>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 995209, XrefRangeEnd = 995212, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe FishyCommentArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Fishy.FishyCommentArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(Fishy.FishyCommentArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static FishyCommentArray()
      {
        Il2CppClassPointerStore<Fishy.FishyCommentArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Fishy>.NativeClassPtr, nameof (FishyCommentArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Fishy.FishyCommentArray>.NativeClassPtr);
        Fishy.FishyCommentArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Fishy.FishyCommentArray>.NativeClassPtr, 100676866);
      }

      public FishyCommentArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
