// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FeedInteractionProgress
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem;
using Stunlock.Localization;
using StunShared.UI;
using System.Runtime.InteropServices;
using UnityEngine.UI;

#nullable disable
namespace ProjectM.UI
{
  public class FeedInteractionProgress : StunGUIBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Motion2DInOut;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextFeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextAbort;
    private static readonly System.IntPtr NativeFieldInfoPtr_Progress;
    private static readonly System.IntPtr NativeFieldInfoPtr_BloodType_VBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Revive;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_ShareKnowledge;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_Feed;
    private static readonly System.IntPtr NativeFieldInfoPtr_LKey_FeedVBlood;
    private static readonly System.IntPtr NativeFieldInfoPtr_Show;
    private static readonly System.IntPtr NativeMethodInfoPtr_SetData_Internal_Void_Single_Single_InputFlag_Boolean_Boolean_Boolean_Nullable_Unboxed_1_BloodConsumeSource_Nullable_Unboxed_1_Blood_GameDataSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Update_Private_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1261177, RefRangeEnd = 1261178, XrefRangeStart = 1261127, XrefRangeEnd = 1261177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void SetData(
      float age,
      float lifetime,
      InputFlag attack1,
      bool showAbortText,
      bool isRevive,
      bool isShareKnowledge,
      Nullable_Unboxed<BloodConsumeSource> bloodConsume,
      Nullable_Unboxed<Blood> blood,
      GameDataSystem gameDataSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[9];
      numPtr[0] = (System.IntPtr) &age;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &lifetime;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &attack1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &showAbortText;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &isRevive;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &isShareKnowledge;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(6) * sizeof (System.IntPtr))) = (System.IntPtr) &bloodConsume;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(7) * sizeof (System.IntPtr))) = (System.IntPtr) &blood;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(8) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) gameDataSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FeedInteractionProgress.NativeMethodInfoPtr_SetData_Internal_Void_Single_Single_InputFlag_Boolean_Boolean_Boolean_Nullable_Unboxed_1_BloodConsumeSource_Nullable_Unboxed_1_Blood_GameDataSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1261178, XrefRangeEnd = 1261181, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void Update()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FeedInteractionProgress.NativeMethodInfoPtr_Update_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe FeedInteractionProgress()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FeedInteractionProgress.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static FeedInteractionProgress()
    {
      Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (FeedInteractionProgress));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr);
      FeedInteractionProgress.NativeFieldInfoPtr_Motion2DInOut = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, nameof (Motion2DInOut));
      FeedInteractionProgress.NativeFieldInfoPtr_TextFeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, nameof (TextFeed));
      FeedInteractionProgress.NativeFieldInfoPtr_TextAbort = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, nameof (TextAbort));
      FeedInteractionProgress.NativeFieldInfoPtr_Progress = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, nameof (Progress));
      FeedInteractionProgress.NativeFieldInfoPtr_BloodType_VBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, nameof (BloodType_VBlood));
      FeedInteractionProgress.NativeFieldInfoPtr_LKey_Revive = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, nameof (LKey_Revive));
      FeedInteractionProgress.NativeFieldInfoPtr_LKey_ShareKnowledge = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, nameof (LKey_ShareKnowledge));
      FeedInteractionProgress.NativeFieldInfoPtr_LKey_Feed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, nameof (LKey_Feed));
      FeedInteractionProgress.NativeFieldInfoPtr_LKey_FeedVBlood = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, nameof (LKey_FeedVBlood));
      FeedInteractionProgress.NativeFieldInfoPtr_Show = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, nameof (Show));
      FeedInteractionProgress.NativeMethodInfoPtr_SetData_Internal_Void_Single_Single_InputFlag_Boolean_Boolean_Boolean_Nullable_Unboxed_1_BloodConsumeSource_Nullable_Unboxed_1_Blood_GameDataSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, 100667252);
      FeedInteractionProgress.NativeMethodInfoPtr_Update_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, 100667253);
      FeedInteractionProgress.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FeedInteractionProgress>.NativeClassPtr, 100667254);
    }

    public FeedInteractionProgress(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe Motion2DInOut Motion2DInOut
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_Motion2DInOut));
        return pointer == System.IntPtr.Zero ? (Motion2DInOut) null : new Motion2DInOut(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_Motion2DInOut), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText TextFeed
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_TextFeed));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_TextFeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizedText TextAbort
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_TextAbort));
        return pointer == System.IntPtr.Zero ? (LocalizedText) null : new LocalizedText(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_TextAbort), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Image Progress
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_Progress));
        return pointer == System.IntPtr.Zero ? (Image) null : new Image(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_Progress), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe LocalizationKey BloodType_VBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_BloodType_VBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_BloodType_VBlood)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Revive
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_LKey_Revive));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_LKey_Revive)) = value;
      }
    }

    public unsafe LocalizationKey LKey_ShareKnowledge
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_LKey_ShareKnowledge));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_LKey_ShareKnowledge)) = value;
      }
    }

    public unsafe LocalizationKey LKey_Feed
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_LKey_Feed));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_LKey_Feed)) = value;
      }
    }

    public unsafe LocalizationKey LKey_FeedVBlood
    {
      get
      {
        return *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_LKey_FeedVBlood));
      }
      [param: In] set
      {
        *(LocalizationKey*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_LKey_FeedVBlood)) = value;
      }
    }

    public unsafe bool Show
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_Show));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(FeedInteractionProgress.NativeFieldInfoPtr_Show)) = value;
      }
    }
  }
}
