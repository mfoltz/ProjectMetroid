// Decompiled with JetBrains decompiler
// Type: ProjectM.UnitCompositionId
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct UnitCompositionId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Id;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_UnitCompositionId_0;
    [FieldOffset(0)]
    public int Id;

    public static unsafe UnitCompositionId Empty
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 55746, RefRangeEnd = 55747, XrefRangeStart = 55746, XrefRangeEnd = 55747, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(UnitCompositionId.NativeMethodInfoPtr_get_Empty_Public_Static_get_UnitCompositionId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(UnitCompositionId*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static UnitCompositionId()
    {
      Il2CppClassPointerStore<UnitCompositionId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (UnitCompositionId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<UnitCompositionId>.NativeClassPtr);
      UnitCompositionId.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<UnitCompositionId>.NativeClassPtr, nameof (Id));
      UnitCompositionId.NativeMethodInfoPtr_get_Empty_Public_Static_get_UnitCompositionId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<UnitCompositionId>.NativeClassPtr, 100667407);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<UnitCompositionId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
