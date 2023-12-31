// Decompiled with JetBrains decompiler
// Type: ProjectM.TilePivotSettings
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Tiles;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct TilePivotSettings
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PivotType;
    private static readonly System.IntPtr NativeFieldInfoPtr_CustomPivotPoint;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Default_Public_Static_get_TilePivotSettings_0;
    [FieldOffset(0)]
    public TilePivotType PivotType;
    [FieldOffset(4)]
    public float2 CustomPivotPoint;

    public static unsafe TilePivotSettings Default
    {
      [CallerCount(18), CachedScanResults(RefRangeStart = 363406, RefRangeEnd = 363424, XrefRangeStart = 363406, XrefRangeEnd = 363424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TilePivotSettings.NativeMethodInfoPtr_get_Default_Public_Static_get_TilePivotSettings_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(TilePivotSettings*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static TilePivotSettings()
    {
      Il2CppClassPointerStore<TilePivotSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (TilePivotSettings));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TilePivotSettings>.NativeClassPtr);
      TilePivotSettings.NativeFieldInfoPtr_PivotType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilePivotSettings>.NativeClassPtr, nameof (PivotType));
      TilePivotSettings.NativeFieldInfoPtr_CustomPivotPoint = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TilePivotSettings>.NativeClassPtr, nameof (CustomPivotPoint));
      TilePivotSettings.NativeMethodInfoPtr_get_Default_Public_Static_get_TilePivotSettings_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TilePivotSettings>.NativeClassPtr, 100664686);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TilePivotSettings>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
