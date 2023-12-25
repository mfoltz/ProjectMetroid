// Decompiled with JetBrains decompiler
// Type: ProjectM.InteractedUpon
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
  public struct InteractedUpon
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Interacting;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockBuildingMovement;
    private static readonly System.IntPtr NativeFieldInfoPtr_BlockBuildingDisassemble;
    private static readonly System.IntPtr NativeMethodInfoPtr_IsInteractedUpon_Public_Boolean_0;
    [FieldOffset(0)]
    public bool Interacting;
    [FieldOffset(1)]
    public bool BlockBuildingMovement;
    [FieldOffset(2)]
    public bool BlockBuildingDisassemble;

    [CallerCount(83)]
    [CachedScanResults(RefRangeStart = 438794, RefRangeEnd = 438877, XrefRangeStart = 438794, XrefRangeEnd = 438877, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe bool IsInteractedUpon()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(InteractedUpon.NativeMethodInfoPtr_IsInteractedUpon_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static InteractedUpon()
    {
      Il2CppClassPointerStore<InteractedUpon>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (InteractedUpon));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InteractedUpon>.NativeClassPtr);
      InteractedUpon.NativeFieldInfoPtr_Interacting = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractedUpon>.NativeClassPtr, nameof (Interacting));
      InteractedUpon.NativeFieldInfoPtr_BlockBuildingMovement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractedUpon>.NativeClassPtr, nameof (BlockBuildingMovement));
      InteractedUpon.NativeFieldInfoPtr_BlockBuildingDisassemble = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InteractedUpon>.NativeClassPtr, nameof (BlockBuildingDisassemble));
      InteractedUpon.NativeMethodInfoPtr_IsInteractedUpon_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InteractedUpon>.NativeClassPtr, 100677471);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<InteractedUpon>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
