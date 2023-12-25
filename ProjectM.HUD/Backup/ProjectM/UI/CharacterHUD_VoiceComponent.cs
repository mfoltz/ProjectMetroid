// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.CharacterHUD_VoiceComponent
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class CharacterHUD_VoiceComponent : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_VoiceMutedIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CachedVoiceIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr_CachedMutedIcon;
    private static readonly System.IntPtr NativeFieldInfoPtr__CurrentData;
    private static readonly System.IntPtr NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_Boolean_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1217953, RefRangeEnd = 1217954, XrefRangeStart = 1217941, XrefRangeEnd = 1217953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void RefreshData([In] ref CharacterHUD_VoiceComponent.Data data, bool voiceConnected)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref data;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &voiceConnected;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_VoiceComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CharacterHUD_VoiceComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CharacterHUD_VoiceComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CharacterHUD_VoiceComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CharacterHUD_VoiceComponent()
    {
      Il2CppClassPointerStore<CharacterHUD_VoiceComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (CharacterHUD_VoiceComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_VoiceComponent>.NativeClassPtr);
      CharacterHUD_VoiceComponent.NativeFieldInfoPtr_VoiceIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_VoiceComponent>.NativeClassPtr, nameof (VoiceIcon));
      CharacterHUD_VoiceComponent.NativeFieldInfoPtr_VoiceMutedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_VoiceComponent>.NativeClassPtr, nameof (VoiceMutedIcon));
      CharacterHUD_VoiceComponent.NativeFieldInfoPtr_CachedVoiceIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_VoiceComponent>.NativeClassPtr, nameof (CachedVoiceIcon));
      CharacterHUD_VoiceComponent.NativeFieldInfoPtr_CachedMutedIcon = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_VoiceComponent>.NativeClassPtr, nameof (CachedMutedIcon));
      CharacterHUD_VoiceComponent.NativeFieldInfoPtr__CurrentData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_VoiceComponent>.NativeClassPtr, nameof (_CurrentData));
      CharacterHUD_VoiceComponent.NativeMethodInfoPtr_RefreshData_Public_Void_byref_Data_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_VoiceComponent>.NativeClassPtr, 100664364);
      CharacterHUD_VoiceComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_VoiceComponent>.NativeClassPtr, 100664365);
    }

    public CharacterHUD_VoiceComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Image VoiceIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_VoiceComponent.NativeFieldInfoPtr_VoiceIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_VoiceComponent.NativeFieldInfoPtr_VoiceIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image VoiceMutedIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_VoiceComponent.NativeFieldInfoPtr_VoiceMutedIcon));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_VoiceComponent.NativeFieldInfoPtr_VoiceMutedIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject CachedVoiceIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_VoiceComponent.NativeFieldInfoPtr_CachedVoiceIcon));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_VoiceComponent.NativeFieldInfoPtr_CachedVoiceIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe GameObject CachedMutedIcon
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_VoiceComponent.NativeFieldInfoPtr_CachedMutedIcon));
        return pointer == System.IntPtr.Zero ? (GameObject) null : new GameObject(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_VoiceComponent.NativeFieldInfoPtr_CachedMutedIcon), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Nullable_Unboxed<CharacterHUD_VoiceComponent.Data> _CurrentData
    {
      get
      {
        return *(Nullable_Unboxed<CharacterHUD_VoiceComponent.Data>*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_VoiceComponent.NativeFieldInfoPtr__CurrentData));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CharacterHUD_VoiceComponent.NativeFieldInfoPtr__CurrentData), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<Nullable_Unboxed<CharacterHUD_VoiceComponent.Data>>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_PrefabType;
      private static readonly System.IntPtr NativeFieldInfoPtr_IsSpeaking;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
      private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
      [FieldOffset(0)]
      public CharacterHUDEntryType PrefabType;
      [FieldOffset(1)]
      public bool IsSpeaking;

      [CallerCount(1)]
      [CachedScanResults(RefRangeStart = 254395, RefRangeEnd = 254396, XrefRangeStart = 254395, XrefRangeEnd = 254396, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(CharacterHUD_VoiceComponent.Data other)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &other;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_VoiceComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217937, XrefRangeEnd = 1217940, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public virtual unsafe bool Equals(Il2CppSystem.Object obj)
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_VoiceComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1217940, XrefRangeEnd = 1217941, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public override unsafe int GetHashCode()
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CharacterHUD_VoiceComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }

      static Data()
      {
        Il2CppClassPointerStore<CharacterHUD_VoiceComponent.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CharacterHUD_VoiceComponent>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CharacterHUD_VoiceComponent.Data>.NativeClassPtr);
        CharacterHUD_VoiceComponent.Data.NativeFieldInfoPtr_PrefabType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_VoiceComponent.Data>.NativeClassPtr, nameof (PrefabType));
        CharacterHUD_VoiceComponent.Data.NativeFieldInfoPtr_IsSpeaking = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CharacterHUD_VoiceComponent.Data>.NativeClassPtr, nameof (IsSpeaking));
        CharacterHUD_VoiceComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_VoiceComponent.Data>.NativeClassPtr, 100664366);
        CharacterHUD_VoiceComponent.Data.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_VoiceComponent.Data>.NativeClassPtr, 100664367);
        CharacterHUD_VoiceComponent.Data.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CharacterHUD_VoiceComponent.Data>.NativeClassPtr, 100664368);
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CharacterHUD_VoiceComponent.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
