// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.DebugLogsView
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
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM.UI
{
  public class DebugLogsView : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_LogsText;
    private static readonly IntPtr NativeFieldInfoPtr_WarningsText;
    private static readonly IntPtr NativeFieldInfoPtr_ErrorsText;
    private static readonly IntPtr NativeFieldInfoPtr_ExceptionsText;
    private static readonly IntPtr NativeFieldInfoPtr__LogsText;
    private static readonly IntPtr NativeFieldInfoPtr__WarningsText;
    private static readonly IntPtr NativeFieldInfoPtr__ErrorsText;
    private static readonly IntPtr NativeFieldInfoPtr__ExceptionsText;
    private static readonly IntPtr NativeFieldInfoPtr__ClientWorld;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetServerLogs_Private_ServerDebugLogs_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277718, XrefRangeEnd = 1277753, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugLogsView.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1277753, XrefRangeEnd = 1277761, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ServerDebugLogs GetServerLogs()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IntPtr num = IL2CPP.il2cpp_runtime_invoke(DebugLogsView.NativeMethodInfoPtr_GetServerLogs_Private_ServerDebugLogs_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(ServerDebugLogs*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DebugLogsView()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DebugLogsView.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DebugLogsView()
    {
      Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (DebugLogsView));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr);
      DebugLogsView.NativeFieldInfoPtr_LogsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, nameof (LogsText));
      DebugLogsView.NativeFieldInfoPtr_WarningsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, nameof (WarningsText));
      DebugLogsView.NativeFieldInfoPtr_ErrorsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, nameof (ErrorsText));
      DebugLogsView.NativeFieldInfoPtr_ExceptionsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, nameof (ExceptionsText));
      DebugLogsView.NativeFieldInfoPtr__LogsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, nameof (_LogsText));
      DebugLogsView.NativeFieldInfoPtr__WarningsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, nameof (_WarningsText));
      DebugLogsView.NativeFieldInfoPtr__ErrorsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, nameof (_ErrorsText));
      DebugLogsView.NativeFieldInfoPtr__ExceptionsText = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, nameof (_ExceptionsText));
      DebugLogsView.NativeFieldInfoPtr__ClientWorld = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, nameof (_ClientWorld));
      DebugLogsView.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, 100668731);
      DebugLogsView.NativeMethodInfoPtr_GetServerLogs_Private_ServerDebugLogs_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, 100668732);
      DebugLogsView.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DebugLogsView>.NativeClassPtr, 100668733);
    }

    public DebugLogsView(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe TMP_Text LogsText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr_LogsText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr_LogsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text WarningsText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr_WarningsText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr_WarningsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ErrorsText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr_ErrorsText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr_ErrorsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe TMP_Text ExceptionsText
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr_ExceptionsText));
        return pointer == IntPtr.Zero ? (TMP_Text) null : new TMP_Text(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr_ExceptionsText), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public MemoizedLogsCountText _LogsText
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr__LogsText);
        return new MemoizedLogsCountText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr__LogsText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedLogsCountText _WarningsText
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr__WarningsText);
        return new MemoizedLogsCountText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr__WarningsText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedLogsCountText _ErrorsText
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr__ErrorsText);
        return new MemoizedLogsCountText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr__ErrorsText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public MemoizedLogsCountText _ExceptionsText
    {
      get
      {
        IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr__ExceptionsText);
        return new MemoizedLogsCountText(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr__ExceptionsText), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<MemoizedLogsCountText>.NativeClassPtr, (uint&) IntPtr.Zero));
      }
    }

    public unsafe World _ClientWorld
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr__ClientWorld));
        return pointer == IntPtr.Zero ? (World) null : new World(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DebugLogsView.NativeFieldInfoPtr__ClientWorld), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
