// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ChatColorsAsset
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  [Serializable]
  public class ChatColorsAsset : ScriptableObject
  {
    private static readonly IntPtr NativeFieldInfoPtr_SelfName;
    private static readonly IntPtr NativeFieldInfoPtr_AlliesName;
    private static readonly IntPtr NativeFieldInfoPtr_AdminName;
    private static readonly IntPtr NativeFieldInfoPtr_OthersName;
    private static readonly IntPtr NativeFieldInfoPtr_GlobalText;
    private static readonly IntPtr NativeFieldInfoPtr_TeamText;
    private static readonly IntPtr NativeFieldInfoPtr_WhisperText;
    private static readonly IntPtr NativeFieldInfoPtr_SystemText;
    private static readonly IntPtr NativeFieldInfoPtr_LoreText;
    private static readonly IntPtr NativeFieldInfoPtr_SelfText;
    private static readonly IntPtr NativeFieldInfoPtr_LocalText;
    private static readonly IntPtr NativeFieldInfoPtr_DisconnectedColor;
    private static readonly IntPtr NativeFieldInfoPtr_ConnectingColor;
    private static readonly IntPtr NativeFieldInfoPtr_ConnectedColor;
    private static readonly IntPtr NativeFieldInfoPtr_LoreScrollingTimePerCharacter;
    private static readonly IntPtr NativeFieldInfoPtr__SelfName;
    private static readonly IntPtr NativeFieldInfoPtr__AlliesName;
    private static readonly IntPtr NativeFieldInfoPtr__OthersName;
    private static readonly IntPtr NativeFieldInfoPtr__AdminName;
    private static readonly IntPtr NativeFieldInfoPtr__GlobalText;
    private static readonly IntPtr NativeFieldInfoPtr__TeamText;
    private static readonly IntPtr NativeFieldInfoPtr__WhisperText;
    private static readonly IntPtr NativeFieldInfoPtr__LocalText;
    private static readonly IntPtr NativeFieldInfoPtr__SystemText;
    private static readonly IntPtr NativeFieldInfoPtr__SelfText;
    private static readonly IntPtr NativeMethodInfoPtr_get_SelfNameHex_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_AlliesNameHex_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_OthersNameHex_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_AdminNameHex_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_GlobalTextHex_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_TeamTextHex_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_WhisperTextHex_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_LocalTextHex_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_SystemTextHex_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr_get_SelfTextHex_Public_get_String_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    public unsafe string SelfNameHex
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 1220055, RefRangeEnd = 1220057, XrefRangeStart = 1220054, XrefRangeEnd = 1220055, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChatColorsAsset.NativeMethodInfoPtr_get_SelfNameHex_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string AlliesNameHex
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220057, XrefRangeEnd = 1220058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChatColorsAsset.NativeMethodInfoPtr_get_AlliesNameHex_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string OthersNameHex
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1220059, RefRangeEnd = 1220060, XrefRangeStart = 1220058, XrefRangeEnd = 1220059, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChatColorsAsset.NativeMethodInfoPtr_get_OthersNameHex_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string AdminNameHex
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 1220061, RefRangeEnd = 1220062, XrefRangeStart = 1220060, XrefRangeEnd = 1220061, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChatColorsAsset.NativeMethodInfoPtr_get_AdminNameHex_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string GlobalTextHex
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220062, XrefRangeEnd = 1220063, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChatColorsAsset.NativeMethodInfoPtr_get_GlobalTextHex_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string TeamTextHex
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220063, XrefRangeEnd = 1220064, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChatColorsAsset.NativeMethodInfoPtr_get_TeamTextHex_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string WhisperTextHex
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220064, XrefRangeEnd = 1220065, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChatColorsAsset.NativeMethodInfoPtr_get_WhisperTextHex_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string LocalTextHex
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220065, XrefRangeEnd = 1220066, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChatColorsAsset.NativeMethodInfoPtr_get_LocalTextHex_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string SystemTextHex
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220066, XrefRangeEnd = 1220067, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChatColorsAsset.NativeMethodInfoPtr_get_SystemTextHex_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    public unsafe string SelfTextHex
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220067, XrefRangeEnd = 1220068, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(ChatColorsAsset.NativeMethodInfoPtr_get_SelfTextHex_Public_get_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return IL2CPP.Il2CppStringToManaged(il2CppString);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1220068, XrefRangeEnd = 1220069, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChatColorsAsset()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChatColorsAsset.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChatColorsAsset()
    {
      Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ChatColorsAsset));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr);
      ChatColorsAsset.NativeFieldInfoPtr_SelfName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (SelfName));
      ChatColorsAsset.NativeFieldInfoPtr_AlliesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (AlliesName));
      ChatColorsAsset.NativeFieldInfoPtr_AdminName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (AdminName));
      ChatColorsAsset.NativeFieldInfoPtr_OthersName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (OthersName));
      ChatColorsAsset.NativeFieldInfoPtr_GlobalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (GlobalText));
      ChatColorsAsset.NativeFieldInfoPtr_TeamText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (TeamText));
      ChatColorsAsset.NativeFieldInfoPtr_WhisperText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (WhisperText));
      ChatColorsAsset.NativeFieldInfoPtr_SystemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (SystemText));
      ChatColorsAsset.NativeFieldInfoPtr_LoreText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (LoreText));
      ChatColorsAsset.NativeFieldInfoPtr_SelfText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (SelfText));
      ChatColorsAsset.NativeFieldInfoPtr_LocalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (LocalText));
      ChatColorsAsset.NativeFieldInfoPtr_DisconnectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (DisconnectedColor));
      ChatColorsAsset.NativeFieldInfoPtr_ConnectingColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (ConnectingColor));
      ChatColorsAsset.NativeFieldInfoPtr_ConnectedColor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (ConnectedColor));
      ChatColorsAsset.NativeFieldInfoPtr_LoreScrollingTimePerCharacter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (LoreScrollingTimePerCharacter));
      ChatColorsAsset.NativeFieldInfoPtr__SelfName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (_SelfName));
      ChatColorsAsset.NativeFieldInfoPtr__AlliesName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (_AlliesName));
      ChatColorsAsset.NativeFieldInfoPtr__OthersName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (_OthersName));
      ChatColorsAsset.NativeFieldInfoPtr__AdminName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (_AdminName));
      ChatColorsAsset.NativeFieldInfoPtr__GlobalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (_GlobalText));
      ChatColorsAsset.NativeFieldInfoPtr__TeamText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (_TeamText));
      ChatColorsAsset.NativeFieldInfoPtr__WhisperText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (_WhisperText));
      ChatColorsAsset.NativeFieldInfoPtr__LocalText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (_LocalText));
      ChatColorsAsset.NativeFieldInfoPtr__SystemText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (_SystemText));
      ChatColorsAsset.NativeFieldInfoPtr__SelfText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, nameof (_SelfText));
      ChatColorsAsset.NativeMethodInfoPtr_get_SelfNameHex_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, 100664571);
      ChatColorsAsset.NativeMethodInfoPtr_get_AlliesNameHex_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, 100664572);
      ChatColorsAsset.NativeMethodInfoPtr_get_OthersNameHex_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, 100664573);
      ChatColorsAsset.NativeMethodInfoPtr_get_AdminNameHex_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, 100664574);
      ChatColorsAsset.NativeMethodInfoPtr_get_GlobalTextHex_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, 100664575);
      ChatColorsAsset.NativeMethodInfoPtr_get_TeamTextHex_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, 100664576);
      ChatColorsAsset.NativeMethodInfoPtr_get_WhisperTextHex_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, 100664577);
      ChatColorsAsset.NativeMethodInfoPtr_get_LocalTextHex_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, 100664578);
      ChatColorsAsset.NativeMethodInfoPtr_get_SystemTextHex_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, 100664579);
      ChatColorsAsset.NativeMethodInfoPtr_get_SelfTextHex_Public_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, 100664580);
      ChatColorsAsset.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChatColorsAsset>.NativeClassPtr, 100664581);
    }

    public ChatColorsAsset(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Color SelfName
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_SelfName));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_SelfName)) = value;
      }
    }

    public unsafe Color AlliesName
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_AlliesName));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_AlliesName)) = value;
      }
    }

    public unsafe Color AdminName
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_AdminName));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_AdminName)) = value;
      }
    }

    public unsafe Color OthersName
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_OthersName));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_OthersName)) = value;
      }
    }

    public unsafe Color GlobalText
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_GlobalText));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_GlobalText)) = value;
      }
    }

    public unsafe Color TeamText
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_TeamText));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_TeamText)) = value;
      }
    }

    public unsafe Color WhisperText
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_WhisperText));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_WhisperText)) = value;
      }
    }

    public unsafe Color SystemText
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_SystemText));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_SystemText)) = value;
      }
    }

    public unsafe Color LoreText
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_LoreText));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_LoreText)) = value;
      }
    }

    public unsafe Color SelfText
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_SelfText));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_SelfText)) = value;
      }
    }

    public unsafe Color LocalText
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_LocalText));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_LocalText)) = value;
      }
    }

    public unsafe Color DisconnectedColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_DisconnectedColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_DisconnectedColor)) = value;
      }
    }

    public unsafe Color ConnectingColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_ConnectingColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_ConnectingColor)) = value;
      }
    }

    public unsafe Color ConnectedColor
    {
      get
      {
        return *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_ConnectedColor));
      }
      [param: In] set
      {
        *(Color*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_ConnectedColor)) = value;
      }
    }

    public unsafe float LoreScrollingTimePerCharacter
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_LoreScrollingTimePerCharacter));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr_LoreScrollingTimePerCharacter)) = value;
      }
    }

    public MemoizedColor _SelfName
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__SelfName);
        return new MemoizedColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__SelfName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedColor _AlliesName
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__AlliesName);
        return new MemoizedColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__AlliesName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedColor _OthersName
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__OthersName);
        return new MemoizedColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__OthersName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedColor _AdminName
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__AdminName);
        return new MemoizedColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__AdminName), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedColor _GlobalText
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__GlobalText);
        return new MemoizedColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__GlobalText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedColor _TeamText
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__TeamText);
        return new MemoizedColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__TeamText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedColor _WhisperText
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__WhisperText);
        return new MemoizedColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__WhisperText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedColor _LocalText
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__LocalText);
        return new MemoizedColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__LocalText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedColor _SystemText
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__SystemText);
        return new MemoizedColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__SystemText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedColor _SelfText
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__SelfText);
        return new MemoizedColor(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChatColorsAsset.NativeFieldInfoPtr__SelfText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedColor>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }
  }
}
