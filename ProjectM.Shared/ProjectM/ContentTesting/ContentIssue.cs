// Decompiled with JetBrains decompiler
// Type: ProjectM.ContentTesting.ContentIssue
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.ContentTesting
{
  public class ContentIssue : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeFieldInfoPtr_Title;
    private static readonly System.IntPtr NativeFieldInfoPtr_Asset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Category;
    private static readonly System.IntPtr NativeFieldInfoPtr_Severity;
    private static readonly System.IntPtr NativeFieldInfoPtr_GoTo;
    private static readonly System.IntPtr NativeFieldInfoPtr_Hotfixes;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubIssues;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateError_Public_Static_ContentIssue_IssueCategory_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateError_Public_Static_ContentIssue_IssueCategory_String_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateWarning_Public_Static_ContentIssue_IssueCategory_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateWarning_Public_Static_ContentIssue_IssueCategory_String_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateIssue_Public_Static_ContentIssue_IssueCategory_IssueSeverity_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateIssue_Public_Static_ContentIssue_IssueCategory_IssueSeverity_String_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubIssue_Public_ContentIssue_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_SubIssue_Public_ContentIssue_String_String_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddHotfix_Public_Void_String_Action_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765867, XrefRangeEnd = 765882, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ContentIssue()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContentIssue.NativeMethodInfoPtr__ctor_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(37)]
    [CachedScanResults(RefRangeStart = 765883, RefRangeEnd = 765920, XrefRangeStart = 765882, XrefRangeEnd = 765883, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ContentIssue CreateError(
      IssueCategory category,
      string title,
      UnityEngine.Object asset = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &category;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContentIssue.NativeMethodInfoPtr_CreateError_Public_Static_ContentIssue_IssueCategory_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ContentIssue) null : new ContentIssue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765920, XrefRangeEnd = 765921, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ContentIssue CreateError(
      IssueCategory category,
      string id,
      string title,
      UnityEngine.Object asset = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &category;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(id);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContentIssue.NativeMethodInfoPtr_CreateError_Public_Static_ContentIssue_IssueCategory_String_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ContentIssue) null : new ContentIssue(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 765922, RefRangeEnd = 765923, XrefRangeStart = 765921, XrefRangeEnd = 765922, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ContentIssue CreateWarning(
      IssueCategory category,
      string title,
      UnityEngine.Object asset = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &category;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContentIssue.NativeMethodInfoPtr_CreateWarning_Public_Static_ContentIssue_IssueCategory_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ContentIssue) null : new ContentIssue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765923, XrefRangeEnd = 765924, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ContentIssue CreateWarning(
      IssueCategory category,
      string id,
      string title,
      UnityEngine.Object asset = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &category;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(id);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContentIssue.NativeMethodInfoPtr_CreateWarning_Public_Static_ContentIssue_IssueCategory_String_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ContentIssue) null : new ContentIssue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765924, XrefRangeEnd = 765925, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ContentIssue CreateIssue(
      IssueCategory category,
      IssueSeverity severity,
      string title,
      UnityEngine.Object asset = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = (System.IntPtr) &category;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &severity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContentIssue.NativeMethodInfoPtr_CreateIssue_Public_Static_ContentIssue_IssueCategory_IssueSeverity_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ContentIssue) null : new ContentIssue(pointer);
    }

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 765946, RefRangeEnd = 765953, XrefRangeStart = 765925, XrefRangeEnd = 765946, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe ContentIssue CreateIssue(
      IssueCategory category,
      IssueSeverity severity,
      string id,
      string title,
      UnityEngine.Object asset = null)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &category;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &severity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(id);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContentIssue.NativeMethodInfoPtr_CreateIssue_Public_Static_ContentIssue_IssueCategory_IssueSeverity_String_String_Object_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ContentIssue) null : new ContentIssue(pointer);
    }

    [CallerCount(9)]
    [CachedScanResults(RefRangeStart = 765957, RefRangeEnd = 765966, XrefRangeStart = 765953, XrefRangeEnd = 765957, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ContentIssue SubIssue(string title, UnityEngine.Object asset = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(title);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContentIssue.NativeMethodInfoPtr_SubIssue_Public_ContentIssue_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ContentIssue) null : new ContentIssue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765966, XrefRangeEnd = 765970, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ContentIssue SubIssue(string id, string title, UnityEngine.Object asset = null)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(id);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(title);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ContentIssue.NativeMethodInfoPtr_SubIssue_Public_ContentIssue_String_String_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      System.IntPtr pointer = num;
      return pointer == System.IntPtr.Zero ? (ContentIssue) null : new ContentIssue(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 765970, XrefRangeEnd = 765980, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void AddHotfix(string hotFixTitle, Il2CppSystem.Action action)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(hotFixTitle);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) action);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ContentIssue.NativeMethodInfoPtr_AddHotfix_Public_Void_String_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ContentIssue()
    {
      Il2CppClassPointerStore<ContentIssue>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.ContentTesting", nameof (ContentIssue));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr);
      ContentIssue.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, nameof (Id));
      ContentIssue.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, nameof (Title));
      ContentIssue.NativeFieldInfoPtr_Asset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, nameof (Asset));
      ContentIssue.NativeFieldInfoPtr_Category = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, nameof (Category));
      ContentIssue.NativeFieldInfoPtr_Severity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, nameof (Severity));
      ContentIssue.NativeFieldInfoPtr_GoTo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, nameof (GoTo));
      ContentIssue.NativeFieldInfoPtr_Hotfixes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, nameof (Hotfixes));
      ContentIssue.NativeFieldInfoPtr_SubIssues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, nameof (SubIssues));
      ContentIssue.NativeMethodInfoPtr__ctor_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, 100667690);
      ContentIssue.NativeMethodInfoPtr_CreateError_Public_Static_ContentIssue_IssueCategory_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, 100667691);
      ContentIssue.NativeMethodInfoPtr_CreateError_Public_Static_ContentIssue_IssueCategory_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, 100667692);
      ContentIssue.NativeMethodInfoPtr_CreateWarning_Public_Static_ContentIssue_IssueCategory_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, 100667693);
      ContentIssue.NativeMethodInfoPtr_CreateWarning_Public_Static_ContentIssue_IssueCategory_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, 100667694);
      ContentIssue.NativeMethodInfoPtr_CreateIssue_Public_Static_ContentIssue_IssueCategory_IssueSeverity_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, 100667695);
      ContentIssue.NativeMethodInfoPtr_CreateIssue_Public_Static_ContentIssue_IssueCategory_IssueSeverity_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, 100667696);
      ContentIssue.NativeMethodInfoPtr_SubIssue_Public_ContentIssue_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, 100667697);
      ContentIssue.NativeMethodInfoPtr_SubIssue_Public_ContentIssue_String_String_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, 100667698);
      ContentIssue.NativeMethodInfoPtr_AddHotfix_Public_Void_String_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ContentIssue>.NativeClassPtr, 100667699);
    }

    public ContentIssue(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string Id
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Id)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Id), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Title
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Title)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe UnityEngine.Object Asset
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Asset));
        return pointer == System.IntPtr.Zero ? (UnityEngine.Object) null : new UnityEngine.Object(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Asset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe IssueCategory Category
    {
      get
      {
        return *(IssueCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Category));
      }
      [param: In] set
      {
        *(IssueCategory*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Category)) = value;
      }
    }

    public unsafe IssueSeverity Severity
    {
      get
      {
        return *(IssueSeverity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Severity));
      }
      [param: In] set
      {
        *(IssueSeverity*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Severity)) = value;
      }
    }

    public unsafe Il2CppSystem.Action GoTo
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_GoTo));
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Action) null : new Il2CppSystem.Action(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_GoTo), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ContentHotfix> Hotfixes
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Hotfixes));
        return pointer == System.IntPtr.Zero ? (List<ContentHotfix>) null : new List<ContentHotfix>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_Hotfixes), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe List<ContentIssue> SubIssues
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_SubIssues));
        return pointer == System.IntPtr.Zero ? (List<ContentIssue>) null : new List<ContentIssue>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ContentIssue.NativeFieldInfoPtr_SubIssues), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
