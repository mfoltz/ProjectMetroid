// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.SwatchSetupFlags
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [Serializable]
  public class SwatchSetupFlags : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SwatchGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SubSwatchAssetIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_SetupFlagMask;
    private static readonly System.IntPtr NativeFieldInfoPtr_CurrentSwatchEntryIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_SwatchEntryNameHash;
    private static readonly System.IntPtr NativeFieldInfoPtr_CopyAlphaFromVFX;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SwatchSetupFlags()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SwatchSetupFlags>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SwatchSetupFlags.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SwatchSetupFlags()
    {
      Il2CppClassPointerStore<SwatchSetupFlags>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (SwatchSetupFlags));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SwatchSetupFlags>.NativeClassPtr);
      SwatchSetupFlags.NativeFieldInfoPtr_SwatchGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchSetupFlags>.NativeClassPtr, nameof (SwatchGuid));
      SwatchSetupFlags.NativeFieldInfoPtr_SubSwatchAssetIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchSetupFlags>.NativeClassPtr, nameof (SubSwatchAssetIndex));
      SwatchSetupFlags.NativeFieldInfoPtr_SetupFlagMask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchSetupFlags>.NativeClassPtr, nameof (SetupFlagMask));
      SwatchSetupFlags.NativeFieldInfoPtr_CurrentSwatchEntryIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchSetupFlags>.NativeClassPtr, nameof (CurrentSwatchEntryIndex));
      SwatchSetupFlags.NativeFieldInfoPtr_SwatchEntryNameHash = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchSetupFlags>.NativeClassPtr, nameof (SwatchEntryNameHash));
      SwatchSetupFlags.NativeFieldInfoPtr_CopyAlphaFromVFX = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SwatchSetupFlags>.NativeClassPtr, nameof (CopyAlphaFromVFX));
      SwatchSetupFlags.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SwatchSetupFlags>.NativeClassPtr, 100689733);
    }

    public SwatchSetupFlags(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe string SwatchGuid
    {
      get
      {
        return IL2CPP.Il2CppStringToManaged(*(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_SwatchGuid)));
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_SwatchGuid), IL2CPP.ManagedStringToIl2Cpp(value));
      }
    }

    public unsafe int SubSwatchAssetIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_SubSwatchAssetIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_SubSwatchAssetIndex)) = value;
      }
    }

    public unsafe int SetupFlagMask
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_SetupFlagMask));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_SetupFlagMask)) = value;
      }
    }

    public unsafe int CurrentSwatchEntryIndex
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_CurrentSwatchEntryIndex));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_CurrentSwatchEntryIndex)) = value;
      }
    }

    public unsafe int SwatchEntryNameHash
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_SwatchEntryNameHash));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_SwatchEntryNameHash)) = value;
      }
    }

    public unsafe bool CopyAlphaFromVFX
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_CopyAlphaFromVFX));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SwatchSetupFlags.NativeFieldInfoPtr_CopyAlphaFromVFX)) = value;
      }
    }
  }
}
