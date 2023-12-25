// Decompiled with JetBrains decompiler
// Type: Unity.Properties.Generated.ProjectM_Presentation_MoodAssetRef_PropertyBag
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM;
using ProjectM.Presentation;
using System;

#nullable disable
namespace Unity.Properties.Generated
{
  public class ProjectM_Presentation_MoodAssetRef_PropertyBag : ContainerPropertyBag<MoodAssetRef>
  {
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172201, XrefRangeEnd = 1172214, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ProjectM_Presentation_MoodAssetRef_PropertyBag()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_MoodAssetRef_PropertyBag>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_MoodAssetRef_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ProjectM_Presentation_MoodAssetRef_PropertyBag()
    {
      Il2CppClassPointerStore<ProjectM_Presentation_MoodAssetRef_PropertyBag>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Unity.Properties.Generated", nameof (ProjectM_Presentation_MoodAssetRef_PropertyBag));
      ProjectM_Presentation_MoodAssetRef_PropertyBag.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_MoodAssetRef_PropertyBag>.NativeClassPtr, 100693577);
    }

    public ProjectM_Presentation_MoodAssetRef_PropertyBag(IntPtr pointer)
      : base(pointer)
    {
    }

    public class Mood_Property : Property<MoodAssetRef, MoodSetting>
    {
      private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0;
      private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0;
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_MoodSetting_byref_MoodAssetRef_0;
      private static readonly IntPtr NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MoodAssetRef_MoodSetting_0;

      public override unsafe string Name
      {
        [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1172194, XrefRangeEnd = 1172196, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
        {
          IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IntPtr* numPtr = (IntPtr*) null;
          IntPtr exc;
          IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
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
          IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
          Il2CppException.RaiseExceptionIfNecessary(exc);
          return *(bool*) IL2CPP.il2cpp_object_unbox(num);
        }
      }

      [CallerCount(2)]
      [CachedScanResults(RefRangeStart = 1172199, RefRangeEnd = 1172201, XrefRangeStart = 1172196, XrefRangeEnd = 1172199, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe Mood_Property()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      public override unsafe MoodSetting GetValue(ref MoodAssetRef container)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[1];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        IntPtr exc;
        IntPtr num = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MoodSetting_byref_MoodAssetRef_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref MoodAssetRef local = ref container;
        IntPtr pointer1 = ptr;
        MoodAssetRef moodAssetRef = pointer1 == IntPtr.Zero ? (MoodAssetRef) null : new MoodAssetRef(pointer1);
        local = moodAssetRef;
        IntPtr pointer2 = num;
        return pointer2 == IntPtr.Zero ? (MoodSetting) null : new MoodSetting(pointer2);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe void SetValue(ref MoodAssetRef container, MoodSetting value)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr1 = stackalloc IntPtr[2];
        IntPtr* numPtr2 = numPtr1;
        IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) container);
        IntPtr* numPtr3 = &ptr;
        *numPtr2 = (IntPtr) numPtr3;
        *(IntPtr*) ((IntPtr) numPtr1 + checked (new IntPtr(1) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MoodAssetRef_MoodSetting_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        ref MoodAssetRef local = ref container;
        IntPtr pointer = ptr;
        MoodAssetRef moodAssetRef = pointer == IntPtr.Zero ? (MoodAssetRef) null : new MoodAssetRef(pointer);
        local = moodAssetRef;
      }

      static Mood_Property()
      {
        Il2CppClassPointerStore<ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ProjectM_Presentation_MoodAssetRef_PropertyBag>.NativeClassPtr, nameof (Mood_Property));
        ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property.NativeMethodInfoPtr_get_Name_Public_Virtual_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property>.NativeClassPtr, 100693578);
        ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property.NativeMethodInfoPtr_get_IsReadOnly_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property>.NativeClassPtr, 100693579);
        ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property>.NativeClassPtr, 100693580);
        ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property.NativeMethodInfoPtr_GetValue_Public_Virtual_MoodSetting_byref_MoodAssetRef_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property>.NativeClassPtr, 100693581);
        ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property.NativeMethodInfoPtr_SetValue_Public_Virtual_Void_byref_MoodAssetRef_MoodSetting_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ProjectM_Presentation_MoodAssetRef_PropertyBag.Mood_Property>.NativeClassPtr, 100693582);
      }

      public Mood_Property(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
