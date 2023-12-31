// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.ImmaterialWhileRaided
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ImmaterialWhileRaided
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_BuffStateId;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_IsImmaterial_Public_get_Boolean_0;
    [FieldOffset(0)]
    public ModificationId BuffStateId;

    public unsafe bool IsImmaterial
    {
      [CallerCount(2), CachedScanResults(RefRangeStart = 794111, RefRangeEnd = 794113, XrefRangeStart = 794110, XrefRangeEnd = 794111, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ImmaterialWhileRaided.NativeMethodInfoPtr_get_IsImmaterial_Public_get_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(bool*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static ImmaterialWhileRaided()
    {
      Il2CppClassPointerStore<ImmaterialWhileRaided>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.CastleBuilding", nameof (ImmaterialWhileRaided));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ImmaterialWhileRaided>.NativeClassPtr);
      ImmaterialWhileRaided.NativeFieldInfoPtr_BuffStateId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ImmaterialWhileRaided>.NativeClassPtr, nameof (BuffStateId));
      ImmaterialWhileRaided.NativeMethodInfoPtr_get_IsImmaterial_Public_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ImmaterialWhileRaided>.NativeClassPtr, 100670002);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ImmaterialWhileRaided>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
