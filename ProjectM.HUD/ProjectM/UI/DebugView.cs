// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DebugView
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using TMPro;

#nullable disable
namespace ProjectM.UI
{
  public class DebugView : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_WorldPositionText;
    private static readonly IntPtr NativeFieldInfoPtr_MousePositionText;
    private static readonly IntPtr NativeFieldInfoPtr_CurrentChunkText;
    private static readonly IntPtr NativeFieldInfoPtr_LocalChunkPositionText;
    private static readonly IntPtr NativeFieldInfoPtr_ServerNetStatsText;
    private static readonly IntPtr NativeFieldInfoPtr_ClientNetStatsText;
    private static readonly IntPtr NativeFieldInfoPtr_ServerUsersText;
    private static readonly IntPtr NativeFieldInfoPtr_ClientUsersText;
    private static readonly IntPtr NativeFieldInfoPtr_ServerEntitiesText;
    private static readonly IntPtr NativeFieldInfoPtr_ClientEntitiesText;
    private static readonly IntPtr NativeFieldInfoPtr_ServerNetworkedEntitiesText;
    private static readonly IntPtr NativeFieldInfoPtr_ClientNetworkedEntitiesText;
    private static readonly IntPtr NativeFieldInfoPtr_ServerArchetypesText;
    private static readonly IntPtr NativeFieldInfoPtr_ClientArchetypesText;
    private static readonly IntPtr NativeFieldInfoPtr_ServerChunksText;
    private static readonly IntPtr NativeFieldInfoPtr_ClientChunksText;
    private static readonly IntPtr NativeFieldInfoPtr_ClientConnectionStatusText;
    private static readonly IntPtr NativeFieldInfoPtr_LatencyText;
    private static readonly IntPtr NativeFieldInfoPtr_ServerFpsText;
    private static readonly IntPtr NativeFieldInfoPtr_FpsText;
    private static readonly IntPtr NativeFieldInfoPtr_ReplayText;
    private static readonly IntPtr NativeFieldInfoPtr_AiEnabledCountText;
    private static readonly IntPtr NativeFieldInfoPtr_HybridAssetStreamingText;
    private static readonly IntPtr NativeFieldInfoPtr_UIAssetStreamingText;
    private static readonly IntPtr NativeMethodInfoPtr_TrySetReferences_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1259964, XrefRangeEnd = 1259974, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void TrySetReferences()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugView.NativeMethodInfoPtr_TrySetReferences_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugView>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugView()
    {
      Il2CppClassPointerStore<DebugView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DebugView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugView>.NativeClassPtr);
      DebugView.NativeFieldInfoPtr_WorldPositionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (WorldPositionText));
      DebugView.NativeFieldInfoPtr_MousePositionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (MousePositionText));
      DebugView.NativeFieldInfoPtr_CurrentChunkText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (CurrentChunkText));
      DebugView.NativeFieldInfoPtr_LocalChunkPositionText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (LocalChunkPositionText));
      DebugView.NativeFieldInfoPtr_ServerNetStatsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ServerNetStatsText));
      DebugView.NativeFieldInfoPtr_ClientNetStatsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ClientNetStatsText));
      DebugView.NativeFieldInfoPtr_ServerUsersText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ServerUsersText));
      DebugView.NativeFieldInfoPtr_ClientUsersText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ClientUsersText));
      DebugView.NativeFieldInfoPtr_ServerEntitiesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ServerEntitiesText));
      DebugView.NativeFieldInfoPtr_ClientEntitiesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ClientEntitiesText));
      DebugView.NativeFieldInfoPtr_ServerNetworkedEntitiesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ServerNetworkedEntitiesText));
      DebugView.NativeFieldInfoPtr_ClientNetworkedEntitiesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ClientNetworkedEntitiesText));
      DebugView.NativeFieldInfoPtr_ServerArchetypesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ServerArchetypesText));
      DebugView.NativeFieldInfoPtr_ClientArchetypesText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ClientArchetypesText));
      DebugView.NativeFieldInfoPtr_ServerChunksText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ServerChunksText));
      DebugView.NativeFieldInfoPtr_ClientChunksText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ClientChunksText));
      DebugView.NativeFieldInfoPtr_ClientConnectionStatusText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ClientConnectionStatusText));
      DebugView.NativeFieldInfoPtr_LatencyText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (LatencyText));
      DebugView.NativeFieldInfoPtr_ServerFpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ServerFpsText));
      DebugView.NativeFieldInfoPtr_FpsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (FpsText));
      DebugView.NativeFieldInfoPtr_ReplayText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (ReplayText));
      DebugView.NativeFieldInfoPtr_AiEnabledCountText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (AiEnabledCountText));
      DebugView.NativeFieldInfoPtr_HybridAssetStreamingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (HybridAssetStreamingText));
      DebugView.NativeFieldInfoPtr_UIAssetStreamingText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugView>.NativeClassPtr, nameof (UIAssetStreamingText));
      DebugView.NativeMethodInfoPtr_TrySetReferences_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugView>.NativeClassPtr, 100667192);
      DebugView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugView>.NativeClassPtr, 100667193);
    }

    public DebugView(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TMP_Text WorldPositionText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_WorldPositionText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_WorldPositionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text MousePositionText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_MousePositionText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_MousePositionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text CurrentChunkText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_CurrentChunkText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_CurrentChunkText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text LocalChunkPositionText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_LocalChunkPositionText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_LocalChunkPositionText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerNetStatsText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerNetStatsText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerNetStatsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ClientNetStatsText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientNetStatsText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientNetStatsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerUsersText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerUsersText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerUsersText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ClientUsersText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientUsersText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientUsersText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerEntitiesText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerEntitiesText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerEntitiesText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ClientEntitiesText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientEntitiesText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientEntitiesText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerNetworkedEntitiesText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerNetworkedEntitiesText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerNetworkedEntitiesText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ClientNetworkedEntitiesText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientNetworkedEntitiesText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientNetworkedEntitiesText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerArchetypesText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerArchetypesText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerArchetypesText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ClientArchetypesText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientArchetypesText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientArchetypesText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerChunksText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerChunksText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerChunksText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ClientChunksText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientChunksText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientChunksText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ClientConnectionStatusText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientConnectionStatusText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ClientConnectionStatusText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text LatencyText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_LatencyText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_LatencyText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ServerFpsText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerFpsText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ServerFpsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text FpsText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_FpsText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_FpsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ReplayText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ReplayText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_ReplayText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text AiEnabledCountText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_AiEnabledCountText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_AiEnabledCountText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text HybridAssetStreamingText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_HybridAssetStreamingText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_HybridAssetStreamingText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text UIAssetStreamingText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_UIAssetStreamingText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugView.NativeFieldInfoPtr_UIAssetStreamingText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
