// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.FloatRange
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct FloatRange
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__RandomFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_Max;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetRandomValue_Public_Single_Random_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_FloatRange_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_FloatRange_Single_Single_0;
    [FieldOffset(0)]
    public Nullable_Unboxed<float> _RandomFactor;
    [FieldOffset(8)]
    public float Min;
    [FieldOffset(12)]
    public float Max;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1275210, XrefRangeEnd = 1275217, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float GetRandomValue(Unity.Mathematics.Random random)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &random;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FloatRange.NativeMethodInfoPtr_GetRandomValue_Public_Single_Random_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe FloatRange Create(float value)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &value;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FloatRange.NativeMethodInfoPtr_Create_Public_Static_FloatRange_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(FloatRange*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public static unsafe FloatRange Create(float min, float max)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FloatRange.NativeMethodInfoPtr_Create_Public_Static_FloatRange_Single_Single_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(FloatRange*) IL2CPP.il2cpp_object_unbox(num);
    }

    static FloatRange()
    {
      Il2CppClassPointerStore<FloatRange>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (FloatRange));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FloatRange>.NativeClassPtr);
      FloatRange.NativeFieldInfoPtr__RandomFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatRange>.NativeClassPtr, nameof (_RandomFactor));
      FloatRange.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatRange>.NativeClassPtr, nameof (Min));
      FloatRange.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FloatRange>.NativeClassPtr, nameof (Max));
      FloatRange.NativeMethodInfoPtr_GetRandomValue_Public_Single_Random_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatRange>.NativeClassPtr, 100668431);
      FloatRange.NativeMethodInfoPtr_Create_Public_Static_FloatRange_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatRange>.NativeClassPtr, 100668432);
      FloatRange.NativeMethodInfoPtr_Create_Public_Static_FloatRange_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FloatRange>.NativeClassPtr, 100668433);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FloatRange>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
