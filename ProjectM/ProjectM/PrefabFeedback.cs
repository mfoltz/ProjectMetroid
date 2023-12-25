// Decompiled with JetBrains decompiler
// Type: ProjectM.PrefabFeedback
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class PrefabFeedback : MonoBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_FeedbackEntries;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe PrefabFeedback()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabFeedback>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PrefabFeedback.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PrefabFeedback()
    {
      Il2CppClassPointerStore<PrefabFeedback>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (PrefabFeedback));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabFeedback>.NativeClassPtr);
      PrefabFeedback.NativeFieldInfoPtr_FeedbackEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFeedback>.NativeClassPtr, nameof (FeedbackEntries));
      PrefabFeedback.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFeedback>.NativeClassPtr, 100683302);
    }

    public PrefabFeedback(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe PrefabFeedback.FeedbackEntryArray FeedbackEntries
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.NativeFieldInfoPtr_FeedbackEntries));
        return pointer == System.IntPtr.Zero ? (PrefabFeedback.FeedbackEntryArray) null : new PrefabFeedback.FeedbackEntryArray(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.NativeFieldInfoPtr_FeedbackEntries), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public enum FeedbackCategory
    {
      Animation,
      Audio,
      FX,
      Gameplay,
    }

    public enum FeedbackPriority
    {
      Minor,
      Major,
      Severe,
    }

    public enum FeedbackStatus
    {
      Active,
      Resolved,
    }

    [Serializable]
    public class FeedbackEntry : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Category;
      private static readonly System.IntPtr NativeFieldInfoPtr_Priority;
      private static readonly System.IntPtr NativeFieldInfoPtr_Status;
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      private static readonly System.IntPtr NativeFieldInfoPtr_Reporter;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe FeedbackEntry()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabFeedback.FeedbackEntry>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabFeedback.FeedbackEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static FeedbackEntry()
      {
        Il2CppClassPointerStore<PrefabFeedback.FeedbackEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabFeedback>.NativeClassPtr, nameof (FeedbackEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabFeedback.FeedbackEntry>.NativeClassPtr);
        PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFeedback.FeedbackEntry>.NativeClassPtr, nameof (Category));
        PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Priority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFeedback.FeedbackEntry>.NativeClassPtr, nameof (Priority));
        PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Status = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFeedback.FeedbackEntry>.NativeClassPtr, nameof (Status));
        PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFeedback.FeedbackEntry>.NativeClassPtr, nameof (Text));
        PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Reporter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PrefabFeedback.FeedbackEntry>.NativeClassPtr, nameof (Reporter));
        PrefabFeedback.FeedbackEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFeedback.FeedbackEntry>.NativeClassPtr, 100683303);
      }

      public FeedbackEntry(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe PrefabFeedback.FeedbackCategory Category
      {
        get
        {
          return *(PrefabFeedback.FeedbackCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Category));
        }
        [param: In] set
        {
          *(PrefabFeedback.FeedbackCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Category)) = value;
        }
      }

      public unsafe PrefabFeedback.FeedbackPriority Priority
      {
        get
        {
          return *(PrefabFeedback.FeedbackPriority*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Priority));
        }
        [param: In] set
        {
          *(PrefabFeedback.FeedbackPriority*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Priority)) = value;
        }
      }

      public unsafe PrefabFeedback.FeedbackStatus Status
      {
        get
        {
          return *(PrefabFeedback.FeedbackStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Status));
        }
        [param: In] set
        {
          *(PrefabFeedback.FeedbackStatus*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Status)) = value;
        }
      }

      public unsafe string Text
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Text)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }

      public unsafe string Reporter
      {
        get
        {
          return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Reporter)));
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(PrefabFeedback.FeedbackEntry.NativeFieldInfoPtr_Reporter), IL2CPP.ManagedStringToIl2Cpp(value));
        }
      }
    }

    [Serializable]
    public class FeedbackEntryArray : ReorderableArray<PrefabFeedback.FeedbackEntry>
    {
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1061817, XrefRangeEnd = 1061820, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe FeedbackEntryArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PrefabFeedback.FeedbackEntryArray>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PrefabFeedback.FeedbackEntryArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static FeedbackEntryArray()
      {
        Il2CppClassPointerStore<PrefabFeedback.FeedbackEntryArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PrefabFeedback>.NativeClassPtr, nameof (FeedbackEntryArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PrefabFeedback.FeedbackEntryArray>.NativeClassPtr);
        PrefabFeedback.FeedbackEntryArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PrefabFeedback.FeedbackEntryArray>.NativeClassPtr, 100683304);
      }

      public FeedbackEntryArray(System.IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
