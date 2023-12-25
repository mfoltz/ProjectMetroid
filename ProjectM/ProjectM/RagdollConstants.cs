// Decompiled with JetBrains decompiler
// Type: ProjectM.RagdollConstants
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public static class RagdollConstants : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SLOWDOWN_AFTER_SECONDS;
    private static readonly System.IntPtr NativeFieldInfoPtr_SLOWDOWN_DAMPING_PER_SECOND;
    private static readonly System.IntPtr NativeFieldInfoPtr_DESTROY_AFTER_SECONDS;

    static RagdollConstants()
    {
      Il2CppClassPointerStore<RagdollConstants>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (RagdollConstants));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RagdollConstants>.NativeClassPtr);
      RagdollConstants.NativeFieldInfoPtr_SLOWDOWN_AFTER_SECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollConstants>.NativeClassPtr, nameof (SLOWDOWN_AFTER_SECONDS));
      RagdollConstants.NativeFieldInfoPtr_SLOWDOWN_DAMPING_PER_SECOND = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollConstants>.NativeClassPtr, nameof (SLOWDOWN_DAMPING_PER_SECOND));
      RagdollConstants.NativeFieldInfoPtr_DESTROY_AFTER_SECONDS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RagdollConstants>.NativeClassPtr, nameof (DESTROY_AFTER_SECONDS));
    }

    public RagdollConstants(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe float SLOWDOWN_AFTER_SECONDS
    {
      get
      {
        float slowdownAfterSeconds;
        IL2CPP.il2cpp_field_static_get_value(RagdollConstants.NativeFieldInfoPtr_SLOWDOWN_AFTER_SECONDS, (void*) &slowdownAfterSeconds);
        return slowdownAfterSeconds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RagdollConstants.NativeFieldInfoPtr_SLOWDOWN_AFTER_SECONDS, (void*) &value);
      }
    }

    public static unsafe float SLOWDOWN_DAMPING_PER_SECOND
    {
      get
      {
        float dampingPerSecond;
        IL2CPP.il2cpp_field_static_get_value(RagdollConstants.NativeFieldInfoPtr_SLOWDOWN_DAMPING_PER_SECOND, (void*) &dampingPerSecond);
        return dampingPerSecond;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RagdollConstants.NativeFieldInfoPtr_SLOWDOWN_DAMPING_PER_SECOND, (void*) &value);
      }
    }

    public static unsafe float DESTROY_AFTER_SECONDS
    {
      get
      {
        float destroyAfterSeconds;
        IL2CPP.il2cpp_field_static_get_value(RagdollConstants.NativeFieldInfoPtr_DESTROY_AFTER_SECONDS, (void*) &destroyAfterSeconds);
        return destroyAfterSeconds;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(RagdollConstants.NativeFieldInfoPtr_DESTROY_AFTER_SECONDS, (void*) &value);
      }
    }
  }
}
