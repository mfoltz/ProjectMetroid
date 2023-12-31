// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.ScheduleUtility
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;

#nullable disable
namespace ProjectM.Network
{
  public static class ScheduleUtility : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_CalculateStartIndexAndCount_Public_Static_Void_Int32_Int32_Int32_byref_Int32_byref_Int32_0;

    [CallerCount(0)]
    public static unsafe void CalculateStartIndexAndCount(
      int jobIndex,
      int jobCount,
      int workCount,
      out int start,
      out int count)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[5];
      numPtr[0] = (System.IntPtr) &jobIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &jobCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &workCount;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) ref start;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) ref count;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ScheduleUtility.NativeMethodInfoPtr_CalculateStartIndexAndCount_Public_Static_Void_Int32_Int32_Int32_byref_Int32_byref_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ScheduleUtility()
    {
      Il2CppClassPointerStore<ScheduleUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (ScheduleUtility));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScheduleUtility>.NativeClassPtr);
      ScheduleUtility.NativeMethodInfoPtr_CalculateStartIndexAndCount_Public_Static_Void_Int32_Int32_Int32_byref_Int32_byref_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScheduleUtility>.NativeClassPtr, 100669196);
    }

    public ScheduleUtility(System.IntPtr pointer)
      : base(pointer)
    {
    }
  }
}
