// Decompiled with JetBrains decompiler
// Type: ProjectM.Gameplay.Systems.AoETargetComparer
// Assembly: ProjectM.Gameplay.Systems, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A94142E8-EF78-4164-8E88-3B8A1E13E0A6
// Assembly location: C:\Users\mitch\Downloads\ProjectM.Gameplay.Systems.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Gameplay.Systems
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AoETargetComparer
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_AoETarget_AoETarget_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1449300, XrefRangeEnd = 1449301, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe int Compare(AoETarget a, AoETarget b)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &a;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &b;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AoETargetComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_AoETarget_AoETarget_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AoETargetComparer()
    {
      Il2CppClassPointerStore<AoETargetComparer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Gameplay.Systems.dll", "ProjectM.Gameplay.Systems", nameof (AoETargetComparer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AoETargetComparer>.NativeClassPtr);
      AoETargetComparer.NativeMethodInfoPtr_Compare_Public_Virtual_Final_New_Int32_AoETarget_AoETarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AoETargetComparer>.NativeClassPtr, 100672575);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AoETargetComparer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
