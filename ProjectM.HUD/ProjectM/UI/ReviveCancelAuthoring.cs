// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.ReviveCancelAuthoring
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Stunlock.Localization;
using StunShared.UI;
using System;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class ReviveCancelAuthoring : StunGUIBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Motion2DInOut;
    private static readonly IntPtr NativeFieldInfoPtr_TextGiveUp;
    private static readonly IntPtr NativeFieldInfoPtr_TextDowned;
    private static readonly IntPtr NativeFieldInfoPtr_Progress;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_Downed;
    private static readonly IntPtr NativeFieldInfoPtr_LKey_GiveUp;
    private static readonly IntPtr NativeFieldInfoPtr_CancelTime;
    private static readonly IntPtr NativeFieldInfoPtr_Show;
    private static readonly IntPtr NativeMethodInfoPtr_SetData_Internal_Void_Single_Single_InputFlag_Boolean_GameDataSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1274765, RefRangeEnd = 1274766, XrefRangeStart = 1274754, XrefRangeEnd = 1274765, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      float age,
      float lifetime,
      InputFlag attack1,
      bool showAbortText,
      GameDataSystem gameDataSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[5];
      numPtr[0] = (IntPtr) &age;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &lifetime;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = (IntPtr) &attack1;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(3) * sizeof (IntPtr))) = (IntPtr) &showAbortText;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(4) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReviveCancelAuthoring.NativeMethodInfoPtr_SetData_Internal_Void_Single_Single_InputFlag_Boolean_GameDataSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1274766, XrefRangeEnd = 1274769, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReviveCancelAuthoring.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ReviveCancelAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ReviveCancelAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ReviveCancelAuthoring()
    {
      Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (ReviveCancelAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr);
      ReviveCancelAuthoring.NativeFieldInfoPtr_Motion2DInOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr, nameof (Motion2DInOut));
      ReviveCancelAuthoring.NativeFieldInfoPtr_TextGiveUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr, nameof (TextGiveUp));
      ReviveCancelAuthoring.NativeFieldInfoPtr_TextDowned = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr, nameof (TextDowned));
      ReviveCancelAuthoring.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr, nameof (Progress));
      ReviveCancelAuthoring.NativeFieldInfoPtr_LKey_Downed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr, nameof (LKey_Downed));
      ReviveCancelAuthoring.NativeFieldInfoPtr_LKey_GiveUp = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr, nameof (LKey_GiveUp));
      ReviveCancelAuthoring.NativeFieldInfoPtr_CancelTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr, nameof (CancelTime));
      ReviveCancelAuthoring.NativeFieldInfoPtr_Show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr, nameof (Show));
      ReviveCancelAuthoring.NativeMethodInfoPtr_SetData_Internal_Void_Single_Single_InputFlag_Boolean_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr, 100668372);
      ReviveCancelAuthoring.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr, 100668373);
      ReviveCancelAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ReviveCancelAuthoring>.NativeClassPtr, 100668374);
    }

    public ReviveCancelAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Motion2DInOut Motion2DInOut
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_Motion2DInOut));
        return pointer == IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_Motion2DInOut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText TextGiveUp
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_TextGiveUp));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_TextGiveUp), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText TextDowned
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_TextDowned));
        return pointer == IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_TextDowned), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Progress
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_Progress));
        return pointer == IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_Progress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey LKey_Downed
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_LKey_Downed));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_LKey_Downed)) = value;
      }
    }

    public unsafe LocalizationKey LKey_GiveUp
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_LKey_GiveUp));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_LKey_GiveUp)) = value;
      }
    }

    public unsafe float CancelTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_CancelTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_CancelTime)) = value;
      }
    }

    public unsafe bool Show
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_Show));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ReviveCancelAuthoring.NativeFieldInfoPtr_Show)) = value;
      }
    }
  }
}
