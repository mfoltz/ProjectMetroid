// Decompiled with JetBrains decompiler
// Type: ProjectM.FixedTimeLoop
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
  public struct FixedTimeLoop
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_accumulatedTime;
    private static readonly System.IntPtr NativeFieldInfoPtr_fixedTimeStep;
    private static readonly System.IntPtr NativeFieldInfoPtr_maxTimeSteps;
    private static readonly System.IntPtr NativeFieldInfoPtr_timeSteps;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_BeginUpdate_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ShouldUpdate_Public_Boolean_0;
    [FieldOffset(0)]
    public float accumulatedTime;
    [FieldOffset(4)]
    public readonly float fixedTimeStep;
    [FieldOffset(8)]
    public int timeSteps;

    [CallerCount(0)]
    public unsafe FixedTimeLoop(float timeStep = 0.0166666675f)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &timeStep;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FixedTimeLoop.NativeMethodInfoPtr__ctor_Public_Void_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 978884, XrefRangeEnd = 978885, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void BeginUpdate()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(FixedTimeLoop.NativeMethodInfoPtr_BeginUpdate_Public_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public unsafe bool ShouldUpdate()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(FixedTimeLoop.NativeMethodInfoPtr_ShouldUpdate_Public_Boolean_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static FixedTimeLoop()
    {
      Il2CppClassPointerStore<FixedTimeLoop>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (FixedTimeLoop));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FixedTimeLoop>.NativeClassPtr);
      FixedTimeLoop.NativeFieldInfoPtr_accumulatedTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedTimeLoop>.NativeClassPtr, nameof (accumulatedTime));
      FixedTimeLoop.NativeFieldInfoPtr_fixedTimeStep = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedTimeLoop>.NativeClassPtr, nameof (fixedTimeStep));
      FixedTimeLoop.NativeFieldInfoPtr_maxTimeSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedTimeLoop>.NativeClassPtr, nameof (maxTimeSteps));
      FixedTimeLoop.NativeFieldInfoPtr_timeSteps = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FixedTimeLoop>.NativeClassPtr, nameof (timeSteps));
      FixedTimeLoop.NativeMethodInfoPtr__ctor_Public_Void_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedTimeLoop>.NativeClassPtr, 100675620);
      FixedTimeLoop.NativeMethodInfoPtr_BeginUpdate_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedTimeLoop>.NativeClassPtr, 100675621);
      FixedTimeLoop.NativeMethodInfoPtr_ShouldUpdate_Public_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FixedTimeLoop>.NativeClassPtr, 100675622);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<FixedTimeLoop>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int maxTimeSteps
    {
      get
      {
        int maxTimeSteps;
        IL2CPP.il2cpp_field_static_get_value(FixedTimeLoop.NativeFieldInfoPtr_maxTimeSteps, (void*) &maxTimeSteps);
        return maxTimeSteps;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(FixedTimeLoop.NativeFieldInfoPtr_maxTimeSteps, (void*) &value);
      }
    }
  }
}
