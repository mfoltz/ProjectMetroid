// Decompiled with JetBrains decompiler
// Type: ProjectM.AiPointOfInterestTarget
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AiPointOfInterestTarget
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_TypeModifiable;
    private static readonly System.IntPtr NativeFieldInfoPtr_Range;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Type_Public_get_AiPointOfInterestType_0;
    [FieldOffset(0)]
    public ModifiableInt TypeModifiable;
    [FieldOffset(8)]
    public float Range;

    public unsafe AiPointOfInterestType Type
    {
      [CallerCount(83), CachedScanResults(RefRangeStart = 438794, RefRangeEnd = 438877, XrefRangeStart = 438794, XrefRangeEnd = 438877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AiPointOfInterestTarget.NativeMethodInfoPtr_get_Type_Public_get_AiPointOfInterestType_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AiPointOfInterestType*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static AiPointOfInterestTarget()
    {
      Il2CppClassPointerStore<AiPointOfInterestTarget>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AiPointOfInterestTarget));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AiPointOfInterestTarget>.NativeClassPtr);
      AiPointOfInterestTarget.NativeFieldInfoPtr_TypeModifiable = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPointOfInterestTarget>.NativeClassPtr, nameof (TypeModifiable));
      AiPointOfInterestTarget.NativeFieldInfoPtr_Range = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AiPointOfInterestTarget>.NativeClassPtr, nameof (Range));
      AiPointOfInterestTarget.NativeMethodInfoPtr_get_Type_Public_get_AiPointOfInterestType_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AiPointOfInterestTarget>.NativeClassPtr, 100676120);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AiPointOfInterestTarget>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
