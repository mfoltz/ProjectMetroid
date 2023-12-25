// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.NewsPanelEntryData
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class NewsPanelEntryData : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Duration;
    private static readonly System.IntPtr NativeFieldInfoPtr_ImageURL;
    private static readonly System.IntPtr NativeFieldInfoPtr_LinkURL;
    private static readonly System.IntPtr NativeFieldInfoPtr_LinkText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Title;
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr__ImageUrlHash;
    private static readonly System.IntPtr NativeFieldInfoPtr__HasLink;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ImageUrlHash_Public_get_String_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_HasLink_Public_get_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Process_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe string ImageUrlHash
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 22405, RefRangeEnd = 22406, XrefRangeStart = 22405, XrefRangeEnd = 22406, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(NewsPanelEntryData.NativeMethodInfoPtr_get_ImageUrlHash_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe bool HasLink
    {
      [CallerCount(0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NewsPanelEntryData.NativeMethodInfoPtr_get_HasLink_Public_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1279355, XrefRangeEnd = 1279359, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Process()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntryData.NativeMethodInfoPtr_Process_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe NewsPanelEntryData()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(NewsPanelEntryData.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static NewsPanelEntryData()
    {
      Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (NewsPanelEntryData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr);
      NewsPanelEntryData.NativeFieldInfoPtr_Duration = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, nameof (Duration));
      NewsPanelEntryData.NativeFieldInfoPtr_ImageURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, nameof (ImageURL));
      NewsPanelEntryData.NativeFieldInfoPtr_LinkURL = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, nameof (LinkURL));
      NewsPanelEntryData.NativeFieldInfoPtr_LinkText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, nameof (LinkText));
      NewsPanelEntryData.NativeFieldInfoPtr_Title = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, nameof (Title));
      NewsPanelEntryData.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, nameof (Text));
      NewsPanelEntryData.NativeFieldInfoPtr__ImageUrlHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, nameof (_ImageUrlHash));
      NewsPanelEntryData.NativeFieldInfoPtr__HasLink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, nameof (_HasLink));
      NewsPanelEntryData.NativeMethodInfoPtr_get_ImageUrlHash_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, 100668921);
      NewsPanelEntryData.NativeMethodInfoPtr_get_HasLink_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, 100668922);
      NewsPanelEntryData.NativeMethodInfoPtr_Process_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, 100668923);
      NewsPanelEntryData.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NewsPanelEntryData>.NativeClassPtr, 100668924);
    }

    public NewsPanelEntryData(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float Duration
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_Duration));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_Duration)) = value;
      }
    }

    public unsafe string ImageURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_ImageURL)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_ImageURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string LinkURL
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_LinkURL)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_LinkURL), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string LinkText
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_LinkText)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_LinkText), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Title
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_Title)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_Title), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string Text
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_Text)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr_Text), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe string _ImageUrlHash
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr__ImageUrlHash)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr__ImageUrlHash), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe bool _HasLink
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr__HasLink));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(NewsPanelEntryData.NativeFieldInfoPtr__HasLink)) = value;
      }
    }
  }
}
