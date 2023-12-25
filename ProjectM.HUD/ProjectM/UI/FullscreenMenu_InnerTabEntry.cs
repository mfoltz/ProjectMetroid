// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FullscreenMenu_InnerTabEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class FullscreenMenu_InnerTabEntry : 
    GenericSelectionEntry<FullscreenMenu_InnerTabEntry.Data>
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_Button;
    private static readonly System.IntPtr NativeFieldInfoPtr_NewTagImage;
    private static readonly System.IntPtr NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261996, XrefRangeEnd = 1262002, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void Refresh([In] ref FullscreenMenu_InnerTabEntry.Data data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), FullscreenMenu_InnerTabEntry.NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1262002, XrefRangeEnd = 1262005, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FullscreenMenu_InnerTabEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FullscreenMenu_InnerTabEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FullscreenMenu_InnerTabEntry()
    {
      Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (FullscreenMenu_InnerTabEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry>.NativeClassPtr);
      FullscreenMenu_InnerTabEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry>.NativeClassPtr, nameof (Text));
      FullscreenMenu_InnerTabEntry.NativeFieldInfoPtr_Button = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry>.NativeClassPtr, nameof (Button));
      FullscreenMenu_InnerTabEntry.NativeFieldInfoPtr_NewTagImage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry>.NativeClassPtr, nameof (NewTagImage));
      FullscreenMenu_InnerTabEntry.NativeMethodInfoPtr_Refresh_Internal_Virtual_Void_byref_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry>.NativeClassPtr, 100667343);
      FullscreenMenu_InnerTabEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry>.NativeClassPtr, 100667344);
    }

    public FullscreenMenu_InnerTabEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_InnerTabEntry.NativeFieldInfoPtr_Text));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_InnerTabEntry.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Button
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_InnerTabEntry.NativeFieldInfoPtr_Button));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_InnerTabEntry.NativeFieldInfoPtr_Button), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image NewTagImage
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_InnerTabEntry.NativeFieldInfoPtr_NewTagImage));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FullscreenMenu_InnerTabEntry.NativeFieldInfoPtr_NewTagImage), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_Text;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSelected;
      private static readonly System.IntPtr NativeFieldInfoPtr_Interactable;
      private static readonly System.IntPtr NativeFieldInfoPtr_SetNewTag;
      [FieldOffset(0)]
      public LocalizationKey Text;
      [FieldOffset(16)]
      public bool IsSelected;
      [FieldOffset(17)]
      public bool Interactable;
      [FieldOffset(18)]
      public bool SetNewTag;

      static Data()
      {
        Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry.Data>.NativeClassPtr);
        FullscreenMenu_InnerTabEntry.Data.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry.Data>.NativeClassPtr, nameof (Text));
        FullscreenMenu_InnerTabEntry.Data.NativeFieldInfoPtr_IsSelected = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry.Data>.NativeClassPtr, nameof (IsSelected));
        FullscreenMenu_InnerTabEntry.Data.NativeFieldInfoPtr_Interactable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry.Data>.NativeClassPtr, nameof (Interactable));
        FullscreenMenu_InnerTabEntry.Data.NativeFieldInfoPtr_SetNewTag = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry.Data>.NativeClassPtr, nameof (SetNewTag));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FullscreenMenu_InnerTabEntry.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
