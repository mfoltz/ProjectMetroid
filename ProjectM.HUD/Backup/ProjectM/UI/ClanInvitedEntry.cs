// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ClanInvitedEntry
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using ProjectM.Network;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.UI
{
  public class ClanInvitedEntry : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Text;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanNameText;
    private static readonly System.IntPtr NativeFieldInfoPtr_Accept;
    private static readonly System.IntPtr NativeFieldInfoPtr_Decline;
    private static readonly System.IntPtr NativeFieldInfoPtr_ClanNetworkId;
    private static readonly System.IntPtr NativeMethodInfoPtr_UpdateEntry_Internal_Void_byref_Nullable_Unboxed_1_Data_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1221189, RefRangeEnd = 1221190, XrefRangeStart = 1221154, XrefRangeEnd = 1221189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void UpdateEntry(ref Nullable_Unboxed<ClanInvitedEntry.Data> data)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref data;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanInvitedEntry.NativeMethodInfoPtr_UpdateEntry_Internal_Void_byref_Nullable_Unboxed_1_Data_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ClanInvitedEntry()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ClanInvitedEntry>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ClanInvitedEntry.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ClanInvitedEntry()
    {
      Il2CppClassPointerStore<ClanInvitedEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ClanInvitedEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanInvitedEntry>.NativeClassPtr);
      ClanInvitedEntry.NativeFieldInfoPtr_Text = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitedEntry>.NativeClassPtr, nameof (Text));
      ClanInvitedEntry.NativeFieldInfoPtr_ClanNameText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitedEntry>.NativeClassPtr, nameof (ClanNameText));
      ClanInvitedEntry.NativeFieldInfoPtr_Accept = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitedEntry>.NativeClassPtr, nameof (Accept));
      ClanInvitedEntry.NativeFieldInfoPtr_Decline = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitedEntry>.NativeClassPtr, nameof (Decline));
      ClanInvitedEntry.NativeFieldInfoPtr_ClanNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitedEntry>.NativeClassPtr, nameof (ClanNetworkId));
      ClanInvitedEntry.NativeMethodInfoPtr_UpdateEntry_Internal_Void_byref_Nullable_Unboxed_1_Data_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanInvitedEntry>.NativeClassPtr, 100664658);
      ClanInvitedEntry.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ClanInvitedEntry>.NativeClassPtr, 100664659);
    }

    public ClanInvitedEntry(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe LocalizedText Text
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitedEntry.NativeFieldInfoPtr_Text));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitedEntry.NativeFieldInfoPtr_Text), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText ClanNameText
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitedEntry.NativeFieldInfoPtr_ClanNameText));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitedEntry.NativeFieldInfoPtr_ClanNameText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Accept
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitedEntry.NativeFieldInfoPtr_Accept));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitedEntry.NativeFieldInfoPtr_Accept), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe SimpleStunButton Decline
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitedEntry.NativeFieldInfoPtr_Decline));
        return pointer == System.IntPtr.Zero ? (SimpleStunButton) null : new SimpleStunButton(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitedEntry.NativeFieldInfoPtr_Decline), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe NetworkId ClanNetworkId
    {
      get
      {
        return *(NetworkId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitedEntry.NativeFieldInfoPtr_ClanNetworkId));
      }
      [param: In] set
      {
        *(NetworkId*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ClanInvitedEntry.NativeFieldInfoPtr_ClanNetworkId)) = value;
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct Data
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_ClanName;
      private static readonly System.IntPtr NativeFieldInfoPtr_Player;
      private static readonly System.IntPtr NativeFieldInfoPtr_ClanNetworkId;
      private static readonly System.IntPtr NativeFieldInfoPtr_TimeLeft;
      [FieldOffset(0)]
      public FixedString64 ClanName;
      [FieldOffset(64)]
      public FixedString64 Player;
      [FieldOffset(128)]
      public NetworkId ClanNetworkId;
      [FieldOffset(136)]
      public float TimeLeft;

      static Data()
      {
        Il2CppClassPointerStore<ClanInvitedEntry.Data>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ClanInvitedEntry>.NativeClassPtr, nameof (Data));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ClanInvitedEntry.Data>.NativeClassPtr);
        ClanInvitedEntry.Data.NativeFieldInfoPtr_ClanName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitedEntry.Data>.NativeClassPtr, nameof (ClanName));
        ClanInvitedEntry.Data.NativeFieldInfoPtr_Player = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitedEntry.Data>.NativeClassPtr, nameof (Player));
        ClanInvitedEntry.Data.NativeFieldInfoPtr_ClanNetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitedEntry.Data>.NativeClassPtr, nameof (ClanNetworkId));
        ClanInvitedEntry.Data.NativeFieldInfoPtr_TimeLeft = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ClanInvitedEntry.Data>.NativeClassPtr, nameof (TimeLeft));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ClanInvitedEntry.Data>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
