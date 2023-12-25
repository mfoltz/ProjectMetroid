// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_UI_AchievementCollectionData_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using ProjectM.UI;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_UI_AchievementCollectionData_PropertyBag : 
    ContainerPropertyBag<AchievementCollectionData>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172297, XrefRangeEnd = 1172313, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_UI_AchievementCollectionData_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_AchievementCollectionData_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_AchievementCollectionData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_UI_AchievementCollectionData_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_UI_AchievementCollectionData_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_UI_AchievementCollectionData_PropertyBag));
      ProjectM_UI_AchievementCollectionData_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementCollectionData_PropertyBag>.NativeClassPtr, 100693606);
    }

    public ProjectM_UI_AchievementCollectionData_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Entries_Property : 
      Property<AchievementCollectionData, Il2CppReferenceArray<AchievementEntryData>>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_AchievementEntryData_byref_AchievementCollectionData_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementCollectionData_Il2CppReferenceArray_1_AchievementEntryData_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172290, XrefRangeEnd = 1172292, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return IL2CPP.Il2CppStringToManaged(il2CppString);
        }
      }

      public override unsafe bool IsReadOnly
      {
        [CallerCount(1858), CachedScanResults(RefRangeStart = 33151, RefRangeEnd = 35009, XrefRangeStart = 33151, XrefRangeEnd = 35009, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172295, RefRangeEnd = 1172297, XrefRangeStart = 1172292, XrefRangeEnd = 1172295, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Entries_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe Il2CppReferenceArray<AchievementEntryData> GetValue(
        ref AchievementCollectionData container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_AchievementEntryData_byref_AchievementCollectionData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AchievementCollectionData local = ref container;
        IntPtr pointer = ptr;
        AchievementCollectionData achievementCollectionData = pointer == IntPtr.Zero ? (AchievementCollectionData) null : new AchievementCollectionData(pointer);
        local = achievementCollectionData;
        IntPtr nativeObject = num;
        return nativeObject == IntPtr.Zero ? (Il2CppReferenceArray<AchievementEntryData>) null : new Il2CppReferenceArray<AchievementEntryData>(nativeObject);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(
        ref AchievementCollectionData container,
        Il2CppReferenceArray<AchievementEntryData> value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementCollectionData_Il2CppReferenceArray_1_AchievementEntryData_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref AchievementCollectionData local = ref container;
        IntPtr pointer = ptr;
        AchievementCollectionData achievementCollectionData = pointer == IntPtr.Zero ? (AchievementCollectionData) null : new AchievementCollectionData(pointer);
        local = achievementCollectionData;
      }

      static Entries_Property()
      {
        Il2CppClassPointerStore<ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_UI_AchievementCollectionData_PropertyBag>.NativeClassPtr, nameof (Entries_Property));
        ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property>.NativeClassPtr, 100693607);
        ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property>.NativeClassPtr, 100693608);
        ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property>.NativeClassPtr, 100693609);
        ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_Il2CppReferenceArray_1_AchievementEntryData_byref_AchievementCollectionData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property>.NativeClassPtr, 100693610);
        ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_AchievementCollectionData_Il2CppReferenceArray_1_AchievementEntryData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_UI_AchievementCollectionData_PropertyBag.Entries_Property>.NativeClassPtr, 100693611);
      }

      public Entries_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
